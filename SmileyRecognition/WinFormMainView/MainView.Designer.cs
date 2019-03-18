namespace PatternRecognizer
{
    partial class MainView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.gbTrainSet = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkFile = new System.Windows.Forms.LinkLabel();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.pbPixelImageCanvas = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.modeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.trainTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSmileyText = new System.Windows.Forms.Label();
            this.dgvProbability = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pbSmileyImage = new System.Windows.Forms.PictureBox();
            this.trainPanel = new System.Windows.Forms.Panel();
            this.gbTrainSettings = new System.Windows.Forms.GroupBox();
            this.numEpochCount = new System.Windows.Forms.NumericUpDown();
            this.numMomentum = new System.Windows.Forms.NumericUpDown();
            this.numLearningRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStopTrain = new System.Windows.Forms.Button();
            this.btnStartTrain = new System.Windows.Forms.Button();
            this.gbActivationFunction = new System.Windows.Forms.GroupBox();
            this.rbReLUActivation = new System.Windows.Forms.RadioButton();
            this.rbHyperbolicTangentActivation = new System.Windows.Forms.RadioButton();
            this.rbSigmoidActivation = new System.Windows.Forms.RadioButton();
            this.gbNeuronsCount = new System.Windows.Forms.GroupBox();
            this.numSecondLayerNeuronsCount = new System.Windows.Forms.NumericUpDown();
            this.numFirstLayerNeuronsCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbLayersCount = new System.Windows.Forms.GroupBox();
            this.rbLayers2 = new System.Windows.Forms.RadioButton();
            this.rbLayers1 = new System.Windows.Forms.RadioButton();
            this.rbLayers0 = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblEpoch = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblMeanCost = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.drawPanel.SuspendLayout();
            this.gbTrainSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPixelImageCanvas)).BeginInit();
            this.menu.SuspendLayout();
            this.recognizePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbability)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmileyImage)).BeginInit();
            this.trainPanel.SuspendLayout();
            this.gbTrainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMomentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).BeginInit();
            this.gbActivationFunction.SuspendLayout();
            this.gbNeuronsCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondLayerNeuronsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstLayerNeuronsCount)).BeginInit();
            this.gbLayersCount.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.Controls.Add(this.gbTrainSet);
            this.drawPanel.Controls.Add(this.btnRecognize);
            this.drawPanel.Controls.Add(this.pbPixelImageCanvas);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawPanel.Location = new System.Drawing.Point(0, 24);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Padding = new System.Windows.Forms.Padding(4);
            this.drawPanel.Size = new System.Drawing.Size(358, 479);
            this.drawPanel.TabIndex = 4;
            // 
            // gbTrainSet
            // 
            this.gbTrainSet.Controls.Add(this.label10);
            this.gbTrainSet.Controls.Add(this.linkFile);
            this.gbTrainSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTrainSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTrainSet.Location = new System.Drawing.Point(4, 305);
            this.gbTrainSet.Name = "gbTrainSet";
            this.gbTrainSet.Size = new System.Drawing.Size(350, 67);
            this.gbTrainSet.TabIndex = 1;
            this.gbTrainSet.TabStop = false;
            this.gbTrainSet.Text = "Изображение";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(344, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "(размер каждого образца 5px*7px)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkFile
            // 
            this.linkFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkFile.Location = new System.Drawing.Point(3, 22);
            this.linkFile.Name = "linkFile";
            this.linkFile.Size = new System.Drawing.Size(344, 20);
            this.linkFile.TabIndex = 4;
            this.linkFile.TabStop = true;
            this.linkFile.Text = "Файл с изображениями для обучения сети";
            this.linkFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFile_LinkClicked);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecognize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecognize.Location = new System.Drawing.Point(4, 254);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(350, 51);
            this.btnRecognize.TabIndex = 0;
            this.btnRecognize.Text = "Распознать смайлик";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Visible = false;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // pbPixelImageCanvas
            // 
            this.pbPixelImageCanvas.BackColor = System.Drawing.Color.White;
            this.pbPixelImageCanvas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPixelImageCanvas.Location = new System.Drawing.Point(4, 4);
            this.pbPixelImageCanvas.Name = "pbPixelImageCanvas";
            this.pbPixelImageCanvas.Size = new System.Drawing.Size(350, 250);
            this.pbPixelImageCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPixelImageCanvas.TabIndex = 0;
            this.pbPixelImageCanvas.TabStop = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMI,
            this.modeMI});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1068, 24);
            this.menu.TabIndex = 3;
            // 
            // fileMI
            // 
            this.fileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileTSMI,
            this.saveAsTSMI,
            this.toolStripMenuItem1,
            this.closeTSMI});
            this.fileMI.Name = "fileMI";
            this.fileMI.Size = new System.Drawing.Size(48, 20);
            this.fileMI.Text = "Файл";
            // 
            // openFileTSMI
            // 
            this.openFileTSMI.Name = "openFileTSMI";
            this.openFileTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileTSMI.Size = new System.Drawing.Size(202, 22);
            this.openFileTSMI.Text = "Открыть";
            this.openFileTSMI.Click += new System.EventHandler(this.openFileTSMI_Click);
            // 
            // saveAsTSMI
            // 
            this.saveAsTSMI.Name = "saveAsTSMI";
            this.saveAsTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsTSMI.Size = new System.Drawing.Size(202, 22);
            this.saveAsTSMI.Text = "Сохранить как...";
            this.saveAsTSMI.Click += new System.EventHandler(this.saveAsTSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // closeTSMI
            // 
            this.closeTSMI.Name = "closeTSMI";
            this.closeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeTSMI.Size = new System.Drawing.Size(202, 22);
            this.closeTSMI.Text = "Выход";
            this.closeTSMI.Click += new System.EventHandler(this.closeTSMI_Click);
            // 
            // modeMI
            // 
            this.modeMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recognizeTSMI,
            this.trainTSMI});
            this.modeMI.Name = "modeMI";
            this.modeMI.Size = new System.Drawing.Size(57, 20);
            this.modeMI.Text = "Режим";
            // 
            // recognizeTSMI
            // 
            this.recognizeTSMI.Name = "recognizeTSMI";
            this.recognizeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.recognizeTSMI.Size = new System.Drawing.Size(198, 22);
            this.recognizeTSMI.Text = "Распознавание";
            this.recognizeTSMI.Click += new System.EventHandler(this.recognizeTSMI_Click);
            // 
            // trainTSMI
            // 
            this.trainTSMI.Checked = true;
            this.trainTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trainTSMI.Name = "trainTSMI";
            this.trainTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trainTSMI.Size = new System.Drawing.Size(198, 22);
            this.trainTSMI.Text = "Обучение";
            this.trainTSMI.Click += new System.EventHandler(this.trainTSMI_Click);
            // 
            // recognizePanel
            // 
            this.recognizePanel.Controls.Add(this.panel2);
            this.recognizePanel.Controls.Add(this.dgvProbability);
            this.recognizePanel.Controls.Add(this.panel1);
            this.recognizePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.recognizePanel.Location = new System.Drawing.Point(708, 24);
            this.recognizePanel.Name = "recognizePanel";
            this.recognizePanel.Size = new System.Drawing.Size(350, 479);
            this.recognizePanel.TabIndex = 6;
            this.recognizePanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblSmileyText);
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 176);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.GhostWhite;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(0, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Текст";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmileyText
            // 
            this.lblSmileyText.BackColor = System.Drawing.Color.GhostWhite;
            this.lblSmileyText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSmileyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSmileyText.Location = new System.Drawing.Point(0, 0);
            this.lblSmileyText.Name = "lblSmileyText";
            this.lblSmileyText.Size = new System.Drawing.Size(174, 151);
            this.lblSmileyText.TabIndex = 2;
            this.lblSmileyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProbability
            // 
            this.dgvProbability.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProbability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProbability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProbability.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProbability.Location = new System.Drawing.Point(0, 183);
            this.dgvProbability.Name = "dgvProbability";
            this.dgvProbability.ReadOnly = true;
            this.dgvProbability.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProbability.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProbability.RowHeadersVisible = false;
            this.dgvProbability.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvProbability.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProbability.RowTemplate.ReadOnly = true;
            this.dgvProbability.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProbability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProbability.Size = new System.Drawing.Size(350, 296);
            this.dgvProbability.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pbSmileyImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 176);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(0, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Смайлик";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSmileyImage
            // 
            this.pbSmileyImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSmileyImage.Location = new System.Drawing.Point(0, 0);
            this.pbSmileyImage.Name = "pbSmileyImage";
            this.pbSmileyImage.Size = new System.Drawing.Size(175, 151);
            this.pbSmileyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSmileyImage.TabIndex = 0;
            this.pbSmileyImage.TabStop = false;
            // 
            // trainPanel
            // 
            this.trainPanel.Controls.Add(this.gbTrainSettings);
            this.trainPanel.Controls.Add(this.btnStopTrain);
            this.trainPanel.Controls.Add(this.btnStartTrain);
            this.trainPanel.Controls.Add(this.gbActivationFunction);
            this.trainPanel.Controls.Add(this.gbNeuronsCount);
            this.trainPanel.Controls.Add(this.gbLayersCount);
            this.trainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.trainPanel.Location = new System.Drawing.Point(358, 24);
            this.trainPanel.Name = "trainPanel";
            this.trainPanel.Size = new System.Drawing.Size(350, 479);
            this.trainPanel.TabIndex = 10;
            // 
            // gbTrainSettings
            // 
            this.gbTrainSettings.Controls.Add(this.numEpochCount);
            this.gbTrainSettings.Controls.Add(this.numMomentum);
            this.gbTrainSettings.Controls.Add(this.numLearningRate);
            this.gbTrainSettings.Controls.Add(this.label4);
            this.gbTrainSettings.Controls.Add(this.label8);
            this.gbTrainSettings.Controls.Add(this.label2);
            this.gbTrainSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTrainSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTrainSettings.Location = new System.Drawing.Point(0, 290);
            this.gbTrainSettings.Name = "gbTrainSettings";
            this.gbTrainSettings.Size = new System.Drawing.Size(350, 126);
            this.gbTrainSettings.TabIndex = 3;
            this.gbTrainSettings.TabStop = false;
            this.gbTrainSettings.Text = "Параметры";
            // 
            // numEpochCount
            // 
            this.numEpochCount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEpochCount.Location = new System.Drawing.Point(150, 91);
            this.numEpochCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEpochCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEpochCount.Name = "numEpochCount";
            this.numEpochCount.Size = new System.Drawing.Size(120, 26);
            this.numEpochCount.TabIndex = 2;
            this.numEpochCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEpochCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numMomentum
            // 
            this.numMomentum.DecimalPlaces = 2;
            this.numMomentum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMomentum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMomentum.Location = new System.Drawing.Point(150, 59);
            this.numMomentum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMomentum.Name = "numMomentum";
            this.numMomentum.Size = new System.Drawing.Size(120, 26);
            this.numMomentum.TabIndex = 1;
            this.numMomentum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMomentum.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numLearningRate
            // 
            this.numLearningRate.DecimalPlaces = 2;
            this.numLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numLearningRate.Location = new System.Drawing.Point(150, 26);
            this.numLearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLearningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numLearningRate.Name = "numLearningRate";
            this.numLearningRate.Size = new System.Drawing.Size(120, 26);
            this.numLearningRate.TabIndex = 0;
            this.numLearningRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLearningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Количество эпох";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Момент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Норма обучения";
            // 
            // btnStopTrain
            // 
            this.btnStopTrain.Enabled = false;
            this.btnStopTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopTrain.Location = new System.Drawing.Point(0, 422);
            this.btnStopTrain.Name = "btnStopTrain";
            this.btnStopTrain.Size = new System.Drawing.Size(190, 53);
            this.btnStopTrain.TabIndex = 5;
            this.btnStopTrain.Text = "Остановить обучение";
            this.btnStopTrain.UseVisualStyleBackColor = true;
            // 
            // btnStartTrain
            // 
            this.btnStartTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTrain.Location = new System.Drawing.Point(205, 422);
            this.btnStartTrain.Name = "btnStartTrain";
            this.btnStartTrain.Size = new System.Drawing.Size(145, 53);
            this.btnStartTrain.TabIndex = 4;
            this.btnStartTrain.Text = "Обучить сеть";
            this.btnStartTrain.UseVisualStyleBackColor = true;
            this.btnStartTrain.Click += new System.EventHandler(this.btnStartTrain_Click);
            // 
            // gbActivationFunction
            // 
            this.gbActivationFunction.Controls.Add(this.rbReLUActivation);
            this.gbActivationFunction.Controls.Add(this.rbHyperbolicTangentActivation);
            this.gbActivationFunction.Controls.Add(this.rbSigmoidActivation);
            this.gbActivationFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbActivationFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbActivationFunction.Location = new System.Drawing.Point(0, 162);
            this.gbActivationFunction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.gbActivationFunction.Name = "gbActivationFunction";
            this.gbActivationFunction.Size = new System.Drawing.Size(350, 128);
            this.gbActivationFunction.TabIndex = 2;
            this.gbActivationFunction.TabStop = false;
            this.gbActivationFunction.Text = "Функция активации";
            // 
            // rbReLUActivation
            // 
            this.rbReLUActivation.AutoSize = true;
            this.rbReLUActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbReLUActivation.Location = new System.Drawing.Point(6, 93);
            this.rbReLUActivation.Name = "rbReLUActivation";
            this.rbReLUActivation.Size = new System.Drawing.Size(69, 24);
            this.rbReLUActivation.TabIndex = 2;
            this.rbReLUActivation.TabStop = true;
            this.rbReLUActivation.Tag = "ReLU";
            this.rbReLUActivation.Text = "ReLU";
            this.rbReLUActivation.UseVisualStyleBackColor = true;
            // 
            // rbHyperbolicTangentActivation
            // 
            this.rbHyperbolicTangentActivation.AutoSize = true;
            this.rbHyperbolicTangentActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHyperbolicTangentActivation.Location = new System.Drawing.Point(6, 63);
            this.rbHyperbolicTangentActivation.Name = "rbHyperbolicTangentActivation";
            this.rbHyperbolicTangentActivation.Size = new System.Drawing.Size(225, 24);
            this.rbHyperbolicTangentActivation.TabIndex = 1;
            this.rbHyperbolicTangentActivation.TabStop = true;
            this.rbHyperbolicTangentActivation.Tag = "Tanh";
            this.rbHyperbolicTangentActivation.Text = "Гиперболический тангенс";
            this.rbHyperbolicTangentActivation.UseVisualStyleBackColor = true;
            // 
            // rbSigmoidActivation
            // 
            this.rbSigmoidActivation.AutoSize = true;
            this.rbSigmoidActivation.Checked = true;
            this.rbSigmoidActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbSigmoidActivation.Location = new System.Drawing.Point(6, 31);
            this.rbSigmoidActivation.Name = "rbSigmoidActivation";
            this.rbSigmoidActivation.Size = new System.Drawing.Size(149, 24);
            this.rbSigmoidActivation.TabIndex = 0;
            this.rbSigmoidActivation.TabStop = true;
            this.rbSigmoidActivation.Tag = "Sigmoid";
            this.rbSigmoidActivation.Text = "Сигмоидальная";
            this.rbSigmoidActivation.UseVisualStyleBackColor = true;
            // 
            // gbNeuronsCount
            // 
            this.gbNeuronsCount.Controls.Add(this.numSecondLayerNeuronsCount);
            this.gbNeuronsCount.Controls.Add(this.numFirstLayerNeuronsCount);
            this.gbNeuronsCount.Controls.Add(this.label7);
            this.gbNeuronsCount.Controls.Add(this.label6);
            this.gbNeuronsCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNeuronsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbNeuronsCount.Location = new System.Drawing.Point(0, 61);
            this.gbNeuronsCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.gbNeuronsCount.Name = "gbNeuronsCount";
            this.gbNeuronsCount.Size = new System.Drawing.Size(350, 101);
            this.gbNeuronsCount.TabIndex = 1;
            this.gbNeuronsCount.TabStop = false;
            this.gbNeuronsCount.Text = "Количество нейронов";
            // 
            // numSecondLayerNeuronsCount
            // 
            this.numSecondLayerNeuronsCount.Enabled = false;
            this.numSecondLayerNeuronsCount.Location = new System.Drawing.Point(217, 65);
            this.numSecondLayerNeuronsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSecondLayerNeuronsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSecondLayerNeuronsCount.Name = "numSecondLayerNeuronsCount";
            this.numSecondLayerNeuronsCount.Size = new System.Drawing.Size(120, 26);
            this.numSecondLayerNeuronsCount.TabIndex = 1;
            this.numSecondLayerNeuronsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSecondLayerNeuronsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numFirstLayerNeuronsCount
            // 
            this.numFirstLayerNeuronsCount.Enabled = false;
            this.numFirstLayerNeuronsCount.Location = new System.Drawing.Point(217, 28);
            this.numFirstLayerNeuronsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numFirstLayerNeuronsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFirstLayerNeuronsCount.Name = "numFirstLayerNeuronsCount";
            this.numFirstLayerNeuronsCount.Size = new System.Drawing.Size(120, 26);
            this.numFirstLayerNeuronsCount.TabIndex = 0;
            this.numFirstLayerNeuronsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numFirstLayerNeuronsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "На втором скрытом слое";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "На первом скрытом слое";
            // 
            // gbLayersCount
            // 
            this.gbLayersCount.Controls.Add(this.rbLayers2);
            this.gbLayersCount.Controls.Add(this.rbLayers1);
            this.gbLayersCount.Controls.Add(this.rbLayers0);
            this.gbLayersCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLayersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbLayersCount.Location = new System.Drawing.Point(0, 0);
            this.gbLayersCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.gbLayersCount.Name = "gbLayersCount";
            this.gbLayersCount.Size = new System.Drawing.Size(350, 61);
            this.gbLayersCount.TabIndex = 0;
            this.gbLayersCount.TabStop = false;
            this.gbLayersCount.Text = "Количество скрытых слоев";
            // 
            // rbLayers2
            // 
            this.rbLayers2.AutoSize = true;
            this.rbLayers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLayers2.Location = new System.Drawing.Point(130, 25);
            this.rbLayers2.Name = "rbLayers2";
            this.rbLayers2.Size = new System.Drawing.Size(36, 24);
            this.rbLayers2.TabIndex = 2;
            this.rbLayers2.TabStop = true;
            this.rbLayers2.Text = "2";
            this.rbLayers2.UseVisualStyleBackColor = true;
            // 
            // rbLayers1
            // 
            this.rbLayers1.AutoSize = true;
            this.rbLayers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLayers1.Location = new System.Drawing.Point(71, 25);
            this.rbLayers1.Name = "rbLayers1";
            this.rbLayers1.Size = new System.Drawing.Size(36, 24);
            this.rbLayers1.TabIndex = 1;
            this.rbLayers1.TabStop = true;
            this.rbLayers1.Text = "1";
            this.rbLayers1.UseVisualStyleBackColor = true;
            // 
            // rbLayers0
            // 
            this.rbLayers0.AutoSize = true;
            this.rbLayers0.Checked = true;
            this.rbLayers0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLayers0.Location = new System.Drawing.Point(10, 25);
            this.rbLayers0.Name = "rbLayers0";
            this.rbLayers0.Size = new System.Drawing.Size(36, 24);
            this.rbLayers0.TabIndex = 0;
            this.rbLayers0.TabStop = true;
            this.rbLayers0.Text = "0";
            this.rbLayers0.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.tsLblEpoch,
            this.toolStripStatusLabel4,
            this.tsLblMeanCost,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.tsProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 503);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1068, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel3.Text = "Эпоха:";
            // 
            // tsLblEpoch
            // 
            this.tsLblEpoch.Name = "tsLblEpoch";
            this.tsLblEpoch.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel4.Text = "Ошибка:";
            // 
            // tsLblMeanCost
            // 
            this.tsLblMeanCost.Name = "tsLblMeanCost";
            this.tsLblMeanCost.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(238, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "  ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "Прогрес:";
            // 
            // tsProgress
            // 
            this.tsProgress.AutoSize = false;
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(300, 16);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 525);
            this.Controls.Add(this.recognizePanel);
            this.Controls.Add(this.trainPanel);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.Text = "Form1";
            this.drawPanel.ResumeLayout(false);
            this.gbTrainSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPixelImageCanvas)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.recognizePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbability)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSmileyImage)).EndInit();
            this.trainPanel.ResumeLayout(false);
            this.gbTrainSettings.ResumeLayout(false);
            this.gbTrainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMomentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).EndInit();
            this.gbActivationFunction.ResumeLayout(false);
            this.gbActivationFunction.PerformLayout();
            this.gbNeuronsCount.ResumeLayout(false);
            this.gbNeuronsCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondLayerNeuronsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstLayerNeuronsCount)).EndInit();
            this.gbLayersCount.ResumeLayout(false);
            this.gbLayersCount.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.PictureBox pbPixelImageCanvas;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMI;
        private System.Windows.Forms.ToolStripMenuItem openFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveAsTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeTSMI;
        private System.Windows.Forms.ToolStripMenuItem modeMI;
        private System.Windows.Forms.ToolStripMenuItem recognizeTSMI;
        private System.Windows.Forms.ToolStripMenuItem trainTSMI;
        private System.Windows.Forms.Panel recognizePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSmileyText;
        private System.Windows.Forms.DataGridView dgvProbability;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbSmileyImage;
        private System.Windows.Forms.Panel trainPanel;
        private System.Windows.Forms.GroupBox gbTrainSettings;
        private System.Windows.Forms.NumericUpDown numEpochCount;
        private System.Windows.Forms.NumericUpDown numMomentum;
        private System.Windows.Forms.NumericUpDown numLearningRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStopTrain;
        private System.Windows.Forms.Button btnStartTrain;
        private System.Windows.Forms.GroupBox gbActivationFunction;
        private System.Windows.Forms.RadioButton rbReLUActivation;
        private System.Windows.Forms.RadioButton rbHyperbolicTangentActivation;
        private System.Windows.Forms.RadioButton rbSigmoidActivation;
        private System.Windows.Forms.GroupBox gbNeuronsCount;
        private System.Windows.Forms.NumericUpDown numSecondLayerNeuronsCount;
        private System.Windows.Forms.NumericUpDown numFirstLayerNeuronsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbLayersCount;
        private System.Windows.Forms.RadioButton rbLayers2;
        private System.Windows.Forms.RadioButton rbLayers1;
        private System.Windows.Forms.RadioButton rbLayers0;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.GroupBox gbTrainSet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsLblEpoch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsLblMeanCost;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

