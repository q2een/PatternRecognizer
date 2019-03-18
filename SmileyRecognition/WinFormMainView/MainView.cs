using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognizer
{
    public partial class MainView : Form//, IMainView
    {
        private PixelImageDrawer drawer = new PixelImageDrawer(7, 5);

        private bool isTrainMode;

        public event EventHandler OpenTrainSetClick = delegate { };
        public event EventHandler SaveNetworkClick = delegate { };
        public event EventHandler LoadNetworkClick = delegate { };

        public event EventHandler TrainNetworkClick = delegate { };
        public event EventHandler CancelTrainProcessClick;

        public event EventHandler RecognizeClick = delegate { };

        public bool IsTrainMode
        {
            get => isTrainMode;
            set
            {
                btnRecognize.Visible = !value;
                recognizePanel.Visible = !value;
                drawer.Visible = !value;

                gbTrainSet.Visible = value;
                trainPanel.Visible = value;
                statusStrip.Visible = value;

                recognizeTSMI.Checked = !value;
                trainTSMI.Checked = value;

                isTrainMode = value;
            }
        }

        public double[] CurrentImage => drawer?.CurrentImage;

        #region Параметры обучения нейронной сети.

        public string ActivationName => GetCheckedActivationFunctionName();

        public int HiddenLayersCount => rbLayers0.Checked ? 0 : (rbLayers1.Checked ? 1 : 2);

        public int FirstLayerNeuronsCount => decimal.ToInt32(numFirstLayerNeuronsCount.Value);

        public int SecondLayerNeuronsCount => decimal.ToInt32(numSecondLayerNeuronsCount.Value);

        /// <summary>
        /// Возвращает количество эпох, заднанных пользователем.
        /// </summary>
        public int NumberOfEpochs
        {
            get
            {
                return Decimal.ToInt32(numEpochCount.Value);
            }
        }

        /// <summary>
        /// Возвращает норму обучения, заднанную пользователем.
        /// </summary>
        public double LearningRate
        {
            get
            {
                return Decimal.ToDouble(numLearningRate.Value);
            }
        }

        /// <summary>
        /// Возвращает импульс, заднанный пользователем.
        /// </summary>
        public double Momentum
        {
            get
            {
                return Decimal.ToDouble(numMomentum.Value);
            }
        }

        /// <summary>
        /// Возвращает или задает коллекцию образцов для обучения нейронной сети.
        /// </summary>
        public string TrainSetImagePath { get; private set; }

        public string LoadNetworkPath { get; private set; }

        public string SaveNetworkPath { get; private set; }

        #endregion

        private string GetCheckedActivationFunctionName()
        {
            if (rbSigmoidActivation.Checked)
                return rbSigmoidActivation.Tag.ToString();

            return (rbReLUActivation.Checked ? rbReLUActivation : rbHyperbolicTangentActivation).Tag.ToString();
        }

        // Устанавливает состояние элементов управления в режиме обучения нейронной сети.
        private void EnableTrainPanel(bool enable)
        {
            btnStopTrain.Enabled = !enable;
            btnStartTrain.Enabled = enable;

            modeMI.Enabled = enable;
            openFileTSMI.Enabled = enable;
            saveAsTSMI.Enabled = enable;

            foreach (Control control in trainPanel.Controls)
            {
                if (control is Button)
                    continue;

                control.Enabled = enable;
            }
        }

        public MainView()
        {
            InitializeComponent();

            pbPixelImageCanvas.Controls.Add(drawer);

            IsTrainMode = true;
        }

        private void recognizeTSMI_Click(object sender, EventArgs e) => IsTrainMode = false;

        private void trainTSMI_Click(object sender, EventArgs e) => IsTrainMode = true;
        
        public void SetTrainProgress(int currentEpoch, int epochCount, double meanCost)
        {
            Action action = () => 
            {
                tsProgress.Value = currentEpoch;
                tsLblEpoch.Text = $"{currentEpoch}/{epochCount}";
                tsLblMeanCost.Text = $"{meanCost:0.0000000}";
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

            pbSmileyImage.Image = results.First().Image;
            lblSmileyText.Text = results.First().PatternText;
        }


        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.Filter = "PNG image|*.png";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            pbPixelImageCanvas.Image = Image.FromFile(openFileDialog.FileName);
            TrainSetImagePath = openFileDialog.FileName;

            OpenTrainSetClick(this, EventArgs.Empty);
        }

        #region Пункт меню "Файл".

        private void openFileTSMI_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JSON File|*.json";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            LoadNetworkPath = openFileDialog.FileName;

            LoadNetworkClick(this, EventArgs.Empty);
        }

        private void saveAsTSMI_Click(object sender, EventArgs e)
        {
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

        private void btnRecognize_Click(object sender, EventArgs e) => RecognizeClick(this, EventArgs.Empty);

        private void btnStartTrain_Click(object sender, EventArgs e)
        {
            tsProgress.Maximum = NumberOfEpochs;
            TrainNetworkClick(this, EventArgs.Empty);
        }
    }
}
