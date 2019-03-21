namespace PatternRecognizer
{
    partial class RecognizerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         
        protected void SetFromSize(bool isTrainMode)
        {
            this.Width = leftSide.Width + (isTrainMode ? panelTrain.Width : dgvProbability.Width) + 20;

            this.Height = System.Math.Max(pbPixelImage.Height + (isTrainMode ? gbTrainProcess.Height : panelRecognize.Height), panelTrain.MinimumSize.Height) + menu.Height + 50;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        protected void InitPixelDrawer(int columnCount, int rowCount)
        {
            drawer = new PixelImageDrawer(columnCount, rowCount);

            var size = new System.Drawing.Size(columnCount * DrawerMultiplier, rowCount * DrawerMultiplier);

            pbPixelImage.Size = size;
            pbPixelImage.MinimumSize = size;
            pbPixelImage.MaximumSize = size;

            pbPixelImage.Controls.Add(drawer);
        }

        protected void Initialize(int columnCount, int rowCount)
        {
            InitPixelDrawer(columnCount, rowCount);

            var size = new System.Drawing.Size(System.Math.Max(pbPixelImage.Width, gbTrainProcess.MinimumSize.Width), pbPixelImage.Height + gbTrainProcess.Height);

            drawerContainer.Size = new System.Drawing.Size(size.Width, pbPixelImage.Height);

            pbPixelImage.Location = new System.Drawing.Point((leftSide.Width - pbPixelImage.Width) / 2, pbPixelImage.Location.Y);
            pbPixelImage.Anchor = System.Windows.Forms.AnchorStyles.None;                        

            leftSide.MinimumSize = size;
            leftSide.Size = size;
            gbGrapicsResult.Visible = IsGraphicsResultExists;
        }
         
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbPixelImage = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.modeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.trainTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveLayer = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnAddLayer = new System.Windows.Forms.Button();
            this.btnMoveTop = new System.Windows.Forms.Button();
            this.lstLayers = new System.Windows.Forms.ListBox();
            this.btnStartTrain = new System.Windows.Forms.Button();
            this.panelTrain = new System.Windows.Forms.Panel();
            this.gbTrainSettings = new System.Windows.Forms.GroupBox();
            this.numEpochCount = new System.Windows.Forms.NumericUpDown();
            this.numMomentum = new System.Windows.Forms.NumericUpDown();
            this.numLearningRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTrainSet = new System.Windows.Forms.GroupBox();
            this.linkFile = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditLayer = new System.Windows.Forms.Button();
            this.dgvProbability = new System.Windows.Forms.DataGridView();
            this.leftSide = new System.Windows.Forms.Panel();
            this.drawerContainer = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEpoch = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.progressTrain = new System.Windows.Forms.ProgressBar();
            this.gbTrainProcess = new System.Windows.Forms.GroupBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.gbTextResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbGrapicsResult = new System.Windows.Forms.GroupBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.panelRecognize = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPixelImage)).BeginInit();
            this.menu.SuspendLayout();
            this.panelTrain.SuspendLayout();
            this.gbTrainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMomentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).BeginInit();
            this.gbTrainSet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbability)).BeginInit();
            this.leftSide.SuspendLayout();
            this.drawerContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTrainProcess.SuspendLayout();
            this.gbTextResult.SuspendLayout();
            this.gbGrapicsResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.panelRecognize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPixelImage
            // 
            this.pbPixelImage.BackColor = System.Drawing.Color.White;
            this.pbPixelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPixelImage.Location = new System.Drawing.Point(0, 0);
            this.pbPixelImage.Name = "pbPixelImage";
            this.pbPixelImage.Size = new System.Drawing.Size(320, 174);
            this.pbPixelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPixelImage.TabIndex = 1;
            this.pbPixelImage.TabStop = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMI,
            this.modeMI});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(935, 24);
            this.menu.TabIndex = 0;
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
            this.recognizeTSMI.Click += new System.EventHandler(this.ChangeModeMI_Click);
            // 
            // trainTSMI
            // 
            this.trainTSMI.Checked = true;
            this.trainTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trainTSMI.Name = "trainTSMI";
            this.trainTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trainTSMI.Size = new System.Drawing.Size(198, 22);
            this.trainTSMI.Text = "Обучение";
            this.trainTSMI.Click += new System.EventHandler(this.ChangeModeMI_Click);
            // 
            // btnRemoveLayer
            // 
            this.btnRemoveLayer.Enabled = false;
            this.btnRemoveLayer.Location = new System.Drawing.Point(209, 43);
            this.btnRemoveLayer.Name = "btnRemoveLayer";
            this.btnRemoveLayer.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveLayer.TabIndex = 4;
            this.btnRemoveLayer.Text = "Удалить";
            this.btnRemoveLayer.UseVisualStyleBackColor = true;
            this.btnRemoveLayer.Click += new System.EventHandler(this.btnRemoveLayer_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(9, 44);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(90, 23);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "Вниз";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.Location = new System.Drawing.Point(114, 43);
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(85, 23);
            this.btnAddLayer.TabIndex = 3;
            this.btnAddLayer.Text = "Добавить";
            this.btnAddLayer.UseVisualStyleBackColor = true;
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // btnMoveTop
            // 
            this.btnMoveTop.Enabled = false;
            this.btnMoveTop.Location = new System.Drawing.Point(9, 19);
            this.btnMoveTop.Name = "btnMoveTop";
            this.btnMoveTop.Size = new System.Drawing.Size(90, 23);
            this.btnMoveTop.TabIndex = 0;
            this.btnMoveTop.Text = "Вверх";
            this.btnMoveTop.UseVisualStyleBackColor = true;
            this.btnMoveTop.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lstLayers
            // 
            this.lstLayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLayers.FormattingEnabled = true;
            this.lstLayers.ItemHeight = 16;
            this.lstLayers.Location = new System.Drawing.Point(0, 0);
            this.lstLayers.Name = "lstLayers";
            this.lstLayers.Size = new System.Drawing.Size(300, 132);
            this.lstLayers.TabIndex = 0;
            this.lstLayers.SelectedIndexChanged += new System.EventHandler(this.lstLayers_SelectedIndexChanged);
            // 
            // btnStartTrain
            // 
            this.btnStartTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTrain.Location = new System.Drawing.Point(0, 403);
            this.btnStartTrain.Name = "btnStartTrain";
            this.btnStartTrain.Size = new System.Drawing.Size(300, 35);
            this.btnStartTrain.TabIndex = 4;
            this.btnStartTrain.Text = "Обучить нейронную сеть";
            this.btnStartTrain.UseVisualStyleBackColor = true;
            this.btnStartTrain.Click += new System.EventHandler(this.btnStartTrain_Click);
            // 
            // panelTrain
            // 
            this.panelTrain.Controls.Add(this.btnStartTrain);
            this.panelTrain.Controls.Add(this.gbTrainSettings);
            this.panelTrain.Controls.Add(this.gbTrainSet);
            this.panelTrain.Controls.Add(this.groupBox1);
            this.panelTrain.Controls.Add(this.lstLayers);
            this.panelTrain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTrain.Location = new System.Drawing.Point(620, 24);
            this.panelTrain.MinimumSize = new System.Drawing.Size(300, 440);
            this.panelTrain.Name = "panelTrain";
            this.panelTrain.Size = new System.Drawing.Size(300, 589);
            this.panelTrain.TabIndex = 2;
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
            this.gbTrainSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTrainSettings.Location = new System.Drawing.Point(0, 277);
            this.gbTrainSettings.Name = "gbTrainSettings";
            this.gbTrainSettings.Size = new System.Drawing.Size(300, 126);
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
            this.numEpochCount.Size = new System.Drawing.Size(120, 22);
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
            this.numMomentum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.numMomentum.Size = new System.Drawing.Size(120, 22);
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
            this.numLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.numLearningRate.Size = new System.Drawing.Size(120, 22);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Количество эпох";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Момент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Норма обучения";
            // 
            // gbTrainSet
            // 
            this.gbTrainSet.Controls.Add(this.linkFile);
            this.gbTrainSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTrainSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTrainSet.Location = new System.Drawing.Point(0, 205);
            this.gbTrainSet.Name = "gbTrainSet";
            this.gbTrainSet.Size = new System.Drawing.Size(300, 72);
            this.gbTrainSet.TabIndex = 2;
            this.gbTrainSet.TabStop = false;
            this.gbTrainSet.Text = "Обучающая выборка";
            // 
            // linkFile
            // 
            this.linkFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkFile.Location = new System.Drawing.Point(3, 18);
            this.linkFile.Name = "linkFile";
            this.linkFile.Size = new System.Drawing.Size(294, 51);
            this.linkFile.TabIndex = 0;
            this.linkFile.TabStop = true;
            this.linkFile.Text = "Файл с данными для обучения нейронной сети";
            this.linkFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFile_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMoveTop);
            this.groupBox1.Controls.Add(this.btnAddLayer);
            this.groupBox1.Controls.Add(this.btnEditLayer);
            this.groupBox1.Controls.Add(this.btnRemoveLayer);
            this.groupBox1.Controls.Add(this.btnMoveDown);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление слоями";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(105, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 52);
            this.label1.TabIndex = 3;
            // 
            // btnEditLayer
            // 
            this.btnEditLayer.Enabled = false;
            this.btnEditLayer.Location = new System.Drawing.Point(114, 17);
            this.btnEditLayer.Name = "btnEditLayer";
            this.btnEditLayer.Size = new System.Drawing.Size(180, 23);
            this.btnEditLayer.TabIndex = 2;
            this.btnEditLayer.Text = "Редактировать";
            this.btnEditLayer.UseVisualStyleBackColor = true;
            this.btnEditLayer.Click += new System.EventHandler(this.btnEditLayer_Click);
            // 
            // dgvProbability
            // 
            this.dgvProbability.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProbability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProbability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProbability.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProbability.Location = new System.Drawing.Point(320, 24);
            this.dgvProbability.MinimumSize = new System.Drawing.Size(300, 440);
            this.dgvProbability.Name = "dgvProbability";
            this.dgvProbability.ReadOnly = true;
            this.dgvProbability.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProbability.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProbability.RowHeadersVisible = false;
            this.dgvProbability.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvProbability.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProbability.RowTemplate.ReadOnly = true;
            this.dgvProbability.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProbability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProbability.Size = new System.Drawing.Size(300, 589);
            this.dgvProbability.TabIndex = 1;
            // 
            // leftSide
            // 
            this.leftSide.Controls.Add(this.gbTrainProcess);
            this.leftSide.Controls.Add(this.panelRecognize);
            this.leftSide.Controls.Add(this.drawerContainer);
            this.leftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSide.Location = new System.Drawing.Point(0, 24);
            this.leftSide.Name = "leftSide";
            this.leftSide.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.leftSide.Size = new System.Drawing.Size(320, 589);
            this.leftSide.TabIndex = 0;
            // 
            // drawerContainer
            // 
            this.drawerContainer.Controls.Add(this.pbPixelImage);
            this.drawerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawerContainer.Location = new System.Drawing.Point(0, 0);
            this.drawerContainer.Name = "drawerContainer";
            this.drawerContainer.Size = new System.Drawing.Size(320, 174);
            this.drawerContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEpoch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Эпоха";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEpoch
            // 
            this.lblEpoch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEpoch.Location = new System.Drawing.Point(160, 0);
            this.lblEpoch.Name = "lblEpoch";
            this.lblEpoch.Size = new System.Drawing.Size(151, 33);
            this.lblEpoch.TabIndex = 1;
            this.lblEpoch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 34);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ошибка";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCost.Location = new System.Drawing.Point(160, 33);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(151, 34);
            this.lblCost.TabIndex = 3;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressTrain
            // 
            this.progressTrain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressTrain.Location = new System.Drawing.Point(3, 138);
            this.progressTrain.Name = "progressTrain";
            this.progressTrain.Size = new System.Drawing.Size(314, 34);
            this.progressTrain.TabIndex = 1;
            // 
            // gbTrainProcess
            // 
            this.gbTrainProcess.Controls.Add(this.progressTrain);
            this.gbTrainProcess.Controls.Add(this.tableLayoutPanel1);
            this.gbTrainProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTrainProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTrainProcess.Location = new System.Drawing.Point(0, 349);
            this.gbTrainProcess.MinimumSize = new System.Drawing.Size(272, 175);
            this.gbTrainProcess.Name = "gbTrainProcess";
            this.gbTrainProcess.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.gbTrainProcess.Size = new System.Drawing.Size(320, 175);
            this.gbTrainProcess.TabIndex = 2;
            this.gbTrainProcess.TabStop = false;
            this.gbTrainProcess.Text = "Процесс обучения";
            // 
            // btnRecognize
            // 
            this.btnRecognize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecognize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecognize.Location = new System.Drawing.Point(0, 0);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(320, 36);
            this.btnRecognize.TabIndex = 0;
            this.btnRecognize.Text = "Распознать";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // gbTextResult
            // 
            this.gbTextResult.AutoSize = true;
            this.gbTextResult.Controls.Add(this.lblResult);
            this.gbTextResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTextResult.Location = new System.Drawing.Point(0, 36);
            this.gbTextResult.MinimumSize = new System.Drawing.Size(136, 136);
            this.gbTextResult.Name = "gbTextResult";
            this.gbTextResult.Size = new System.Drawing.Size(136, 139);
            this.gbTextResult.TabIndex = 1;
            this.gbTextResult.TabStop = false;
            this.gbTextResult.Text = "Текст";
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(3, 18);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(130, 118);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbGrapicsResult
            // 
            this.gbGrapicsResult.AutoSize = true;
            this.gbGrapicsResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbGrapicsResult.Controls.Add(this.pbResult);
            this.gbGrapicsResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbGrapicsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGrapicsResult.Location = new System.Drawing.Point(184, 36);
            this.gbGrapicsResult.MinimumSize = new System.Drawing.Size(136, 136);
            this.gbGrapicsResult.Name = "gbGrapicsResult";
            this.gbGrapicsResult.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.gbGrapicsResult.Size = new System.Drawing.Size(136, 139);
            this.gbGrapicsResult.TabIndex = 2;
            this.gbGrapicsResult.TabStop = false;
            this.gbGrapicsResult.Text = "Графика";
            // 
            // pbResult
            // 
            this.pbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbResult.Location = new System.Drawing.Point(1, 16);
            this.pbResult.Margin = new System.Windows.Forms.Padding(0);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(134, 121);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // panelRecognize
            // 
            this.panelRecognize.Controls.Add(this.gbGrapicsResult);
            this.panelRecognize.Controls.Add(this.gbTextResult);
            this.panelRecognize.Controls.Add(this.btnRecognize);
            this.panelRecognize.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecognize.Location = new System.Drawing.Point(0, 174);
            this.panelRecognize.MinimumSize = new System.Drawing.Size(274, 175);
            this.panelRecognize.Name = "panelRecognize";
            this.panelRecognize.Size = new System.Drawing.Size(320, 175);
            this.panelRecognize.TabIndex = 1;
            // 
            // RecognizerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 623);
            this.Controls.Add(this.panelTrain);
            this.Controls.Add(this.dgvProbability);
            this.Controls.Add(this.leftSide);
            this.Controls.Add(this.menu);
            this.MaximizeBox = false;
            this.Name = "RecognizerView";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Text = "RecognizerView";
            this.Load += new System.EventHandler(this.RecognizerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPixelImage)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelTrain.ResumeLayout(false);
            this.gbTrainSettings.ResumeLayout(false);
            this.gbTrainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMomentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).EndInit();
            this.gbTrainSet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbability)).EndInit();
            this.leftSide.ResumeLayout(false);
            this.drawerContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbTrainProcess.ResumeLayout(false);
            this.gbTextResult.ResumeLayout(false);
            this.gbGrapicsResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.panelRecognize.ResumeLayout(false);
            this.panelRecognize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPixelImage;
        private PixelImageDrawer drawer;  
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMI;
        private System.Windows.Forms.ToolStripMenuItem openFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveAsTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeTSMI;
        private System.Windows.Forms.ToolStripMenuItem modeMI;
        private System.Windows.Forms.ToolStripMenuItem recognizeTSMI;
        private System.Windows.Forms.ToolStripMenuItem trainTSMI;
        private System.Windows.Forms.Button btnRemoveLayer;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnAddLayer;
        private System.Windows.Forms.Button btnMoveTop;
        private System.Windows.Forms.ListBox lstLayers;
        private System.Windows.Forms.Button btnStartTrain;
        private System.Windows.Forms.Panel panelTrain;
        private System.Windows.Forms.GroupBox gbTrainSet;
        private System.Windows.Forms.LinkLabel linkFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbTrainSettings;
        private System.Windows.Forms.NumericUpDown numEpochCount;
        private System.Windows.Forms.NumericUpDown numMomentum;
        private System.Windows.Forms.NumericUpDown numLearningRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProbability;
        private System.Windows.Forms.Button btnEditLayer;
        private System.Windows.Forms.Panel leftSide;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel drawerContainer;
        private System.Windows.Forms.GroupBox gbTrainProcess;
        private System.Windows.Forms.ProgressBar progressTrain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEpoch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRecognize;
        private System.Windows.Forms.GroupBox gbGrapicsResult;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.GroupBox gbTextResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRecognize;
    }
}