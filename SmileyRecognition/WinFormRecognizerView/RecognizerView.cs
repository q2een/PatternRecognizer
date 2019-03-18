using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PatternRecognizer.BL.Network;

namespace PatternRecognizer
{
    public partial class RecognizerView : Form, IRecognizerView
    {           
        #region Свойства для графических элементов

        protected int DrawerMultiplier { get; set; } = 50;

        protected string OpenTrainSetFilter { get; set; } = "PNG image|*.png";

        protected string SaveNetworkFilter { get; set; } = "JSON File|*.json";

        protected string LoadNetworkFilter { get; set; } = "JSON File|*.json";

        #endregion

        #region IPatternRecognizerView.

        public IEnumerable<string> Activations { get; private set; }

        public IEnumerable<LayerConfiguration> LayerConfigurations
        {
            get
            {
                foreach (var item in lstLayers.Items)
                {
                    yield return (item as LayerConfigurationView)?.Value;
                }

            }
        }

        private bool isTrainMode;

        public bool IsTrainMode
        {
            get => isTrainMode;
            set
            {                 
                dgvProbability.Visible = !value;
                drawer.Visible = !value;
                panelRecognize.Visible = !value;

                gbTrainProcess.Visible = value;
                panelTrain.Visible = value;

                recognizeTSMI.Checked = !value;
                trainTSMI.Checked = value;

                isTrainMode = value;

                SetFromSize(value);
            }
        }

        public double[] CurrentImage => drawer?.CurrentImage;

        public string ActivationName => LayerConfigurations?.FirstOrDefault().OutputActivationName;

        public int NumberOfEpochs => decimal.ToInt32(numEpochCount.Value);

        public double LearningRate => decimal.ToDouble(numLearningRate.Value);

        public double Momentum => decimal.ToDouble(numMomentum.Value);

        public string TrainSetImagePath { get; private set; }

        public string LoadNetworkPath { get; private set; }

        public string SaveNetworkPath { get; private set; }

        public event EventHandler BeforeLoad = delegate { };
        public event EventHandler OpenTrainSetClick = delegate { };
        public event EventHandler SaveNetworkClick = delegate { };
        public event EventHandler LoadNetworkClick = delegate { };
        public event EventHandler TrainNetworkClick = delegate { };
        public event EventHandler RecognizeClick = delegate { };

        public void SetNetworkProperties(IEnumerable<string> activations, int patternImageWidth, int patternImageHeight, int patternCount)
        {
            Activations = activations ?? throw new ArgumentNullException("activations");

            Initialize(patternImageHeight, patternImageWidth);
            lstLayers.Items.Add(new LayerConfigurationView(patternImageWidth* patternImageHeight, Activations.First()));
            lstLayers.Items.Add(new LayerConfigurationView(patternCount, Activations.First()));
        }

        public void SetTrainProgress(int currentEpoch, int epochCount, double meanCost)
        {
            Action action = () =>
            {
                progressTrain.Value = currentEpoch;
                lblEpoch.Text = $"{currentEpoch}/{epochCount}";
                lblCost.Text = $"{meanCost:0.0000000}";
            };

            if (this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }

        public void SetRecognitionResult(List<RecognizerItem> results)
        {
            results = results.OrderByDescending(i => i.ProbabilityValue).ToList();

            dgvProbability.DataSource = results;

            pbResult.Image = results.First().Image;
            lblResult.Text = results.First().PatternText;
        }

        #endregion

        #region Конструкторы класса.

        public RecognizerView()
        {
            InitializeComponent();
        }

        #endregion

        #region Обработка событий.

        private void RecognizerView_Load(object sender, EventArgs e) => BeforeLoad(this, EventArgs.Empty);
          
        #region Меню.

        #region Пункт меню "Файл".

        private void openFileTSMI_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = LoadNetworkFilter;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            LoadNetworkPath = openFileDialog.FileName;

            LoadNetworkClick(this, EventArgs.Empty);
        }

        private void saveAsTSMI_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = SaveNetworkFilter;

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            SaveNetworkPath = saveFileDialog.FileName;

            SaveNetworkClick(this, EventArgs.Empty);
        }

        private void closeTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
         
        private void ChangeModeMI_Click(object sender, EventArgs e) => IsTrainMode = sender == trainTSMI;
                 
        #endregion

        #region Управление слоями нейронной сети.

        // Обработка события изменения выбранного индекса в списке слоев.
        // Управление видимостью кнопок для управления слоями в зависимости 
        // от выбранного элемента списка (слоя).
        // Для первого слоя можно только изменять функцию активации.
        // Первый слой нельзя перемещать, удалять и изменять количество нейронов.
        private void lstLayers_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int index = lstLayers.SelectedIndex;
            int count = lstLayers.Items.Count;

            btnRemoveLayer.Enabled = index != 0 && index != count - 1;
            btnEditLayer.Enabled = count > 0;

            btnMoveTop.Enabled = index > 1 && index != count - 1;
            btnMoveDown.Enabled = index != count - 1 && index != count-2 && index != 0;
        }

        // Обработка события нажатия на кнопки "Вверх" и "Вниз".
        // Перемещение выделенного слоя вверх или вниз, формируя структуру нейронной сети.
        private void btnMove_Click(object sender, EventArgs e)
        {
            bool isMoveTop = (sender as Button) == btnMoveTop;

            int index = lstLayers.SelectedIndex;
            int insertIndex = isMoveTop ? index - 1 : index + 2;

            lstLayers.Items.Insert(insertIndex, lstLayers.SelectedItem);
            lstLayers.SelectedIndex = insertIndex;
            lstLayers.Items.RemoveAt(index + (isMoveTop ? 1 : 0));
        }

        // Обработка события нажатия на кнопку "Редактировать".
        private void btnEditLayer_Click(object sender, EventArgs e)
        { 
            if (!(lstLayers.SelectedItem is LayerConfigurationView item))
                return;

            var index = lstLayers.SelectedIndex;

            var modal = new LayersManagmentForm(Activations, index == 0 || index == lstLayers.Items.Count-1) { LayerConfiguration = item.Value};

            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                item.Value = modal.LayerConfiguration;
                lstLayers.Items[index] = lstLayers.Items[index];
            }
        }

        // Обработка события нажатия на кнопку "Удалить".
        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {
            int index = lstLayers.SelectedIndex;

            if (index == -1)
                return;
            
            lstLayers.Items.RemoveAt(index);

            lstLayers.SelectedIndex = lstLayers.Items.Count > index ? index : index - 1;
        }

        // Обработка события нажатия на кнопку "Добавить".
        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            var modal = new LayersManagmentForm(Activations);

            if (modal.ShowDialog(this) == DialogResult.OK)
                lstLayers.Items.Insert(lstLayers.Items.Count - 1, new LayerConfigurationView(modal.LayerConfiguration));
        }

        #endregion

        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.Filter = OpenTrainSetFilter;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            pbPixelImage.Image = Image.FromFile(openFileDialog.FileName);
            TrainSetImagePath = openFileDialog.FileName;

            OpenTrainSetClick(this, EventArgs.Empty);
        }

        private void btnRecognize_Click(object sender, EventArgs e) => RecognizeClick(this, EventArgs.Empty);

        private void btnStartTrain_Click(object sender, EventArgs e)
        {
            progressTrain.Maximum = NumberOfEpochs;
            TrainNetworkClick(this, EventArgs.Empty);
        }

        #endregion
        
        #region Вложенный класс для отображения слоя в ListBox.

        private class LayerConfigurationView
        {
            public LayerConfiguration Value { get; set; }

            public LayerConfigurationView(int neuronCount, string outputActivationName)
                : this(new LayerConfiguration(neuronCount, outputActivationName))
            {
            }

            public LayerConfigurationView(LayerConfiguration config)
            {
                Value = config;
            }

            public override string ToString()
            {
                return $"Нейронов: {Value.NeuronCount} | Функция активации: {Value.OutputActivationName}";
            }
        }

        #endregion

    }
}
