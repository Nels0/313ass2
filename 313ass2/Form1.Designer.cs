namespace _313ass2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilterConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFilterConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.temperature1 = new System.Windows.Forms.TextBox();
            this.temperature2 = new System.Windows.Forms.TextBox();
            this.temperature3 = new System.Windows.Forms.TextBox();
            this.temp1CheckBox = new System.Windows.Forms.CheckBox();
            this.temp2CheckBox = new System.Windows.Forms.CheckBox();
            this.temp3CheckBox = new System.Windows.Forms.CheckBox();
            this.setTempBox = new System.Windows.Forms.NumericUpDown();
            this.heaterButton = new System.Windows.Forms.Button();
            this.fanButton = new System.Windows.Forms.Button();
            this.controllerRunButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.filterTypeCombo = new System.Windows.Forms.ComboBox();
            this.filterLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.filterUpdateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.kpUpDown = new System.Windows.Forms.NumericUpDown();
            this.kiUpDown = new System.Windows.Forms.NumericUpDown();
            this.kdUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ambientTempDisplay = new System.Windows.Forms.TextBox();
            this.setTempLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.controllerInputTemp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogfilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openLogfilesToolStripMenuItem
            // 
            this.openLogfilesToolStripMenuItem.Name = "openLogfilesToolStripMenuItem";
            this.openLogfilesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openLogfilesToolStripMenuItem.Text = "&Open Logfiles";
            this.openLogfilesToolStripMenuItem.Click += new System.EventHandler(this.openLogfilesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFilterConfigToolStripMenuItem,
            this.loadFilterConfigToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.editToolStripMenuItem.Text = "&Filter";
            // 
            // saveFilterConfigToolStripMenuItem
            // 
            this.saveFilterConfigToolStripMenuItem.Name = "saveFilterConfigToolStripMenuItem";
            this.saveFilterConfigToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveFilterConfigToolStripMenuItem.Text = "&Save Filter Config";
            this.saveFilterConfigToolStripMenuItem.Click += new System.EventHandler(this.saveFilterConfigToolStripMenuItem_Click);
            // 
            // loadFilterConfigToolStripMenuItem
            // 
            this.loadFilterConfigToolStripMenuItem.Name = "loadFilterConfigToolStripMenuItem";
            this.loadFilterConfigToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.loadFilterConfigToolStripMenuItem.Text = "&Load Custom Filter Config";
            this.loadFilterConfigToolStripMenuItem.Click += new System.EventHandler(this.loadFilterConfigToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // temperature1
            // 
            this.temperature1.Location = new System.Drawing.Point(172, 93);
            this.temperature1.Name = "temperature1";
            this.temperature1.Size = new System.Drawing.Size(49, 20);
            this.temperature1.TabIndex = 2;
            this.temperature1.Text = "0";
            // 
            // temperature2
            // 
            this.temperature2.Location = new System.Drawing.Point(242, 93);
            this.temperature2.Name = "temperature2";
            this.temperature2.Size = new System.Drawing.Size(46, 20);
            this.temperature2.TabIndex = 3;
            this.temperature2.Text = "0";
            // 
            // temperature3
            // 
            this.temperature3.Location = new System.Drawing.Point(312, 94);
            this.temperature3.Name = "temperature3";
            this.temperature3.Size = new System.Drawing.Size(46, 20);
            this.temperature3.TabIndex = 4;
            this.temperature3.Text = "0";
            // 
            // temp1CheckBox
            // 
            this.temp1CheckBox.AutoSize = true;
            this.temp1CheckBox.Checked = true;
            this.temp1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temp1CheckBox.Location = new System.Drawing.Point(190, 117);
            this.temp1CheckBox.Name = "temp1CheckBox";
            this.temp1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.temp1CheckBox.TabIndex = 5;
            this.temp1CheckBox.UseVisualStyleBackColor = true;
            // 
            // temp2CheckBox
            // 
            this.temp2CheckBox.AutoSize = true;
            this.temp2CheckBox.Checked = true;
            this.temp2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temp2CheckBox.Location = new System.Drawing.Point(258, 117);
            this.temp2CheckBox.Name = "temp2CheckBox";
            this.temp2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.temp2CheckBox.TabIndex = 6;
            this.temp2CheckBox.UseVisualStyleBackColor = true;
            // 
            // temp3CheckBox
            // 
            this.temp3CheckBox.AutoSize = true;
            this.temp3CheckBox.Checked = true;
            this.temp3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temp3CheckBox.Location = new System.Drawing.Point(328, 118);
            this.temp3CheckBox.Name = "temp3CheckBox";
            this.temp3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.temp3CheckBox.TabIndex = 7;
            this.temp3CheckBox.UseVisualStyleBackColor = true;
            // 
            // setTempBox
            // 
            this.setTempBox.DecimalPlaces = 1;
            this.setTempBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.setTempBox.Location = new System.Drawing.Point(684, 95);
            this.setTempBox.Name = "setTempBox";
            this.setTempBox.Size = new System.Drawing.Size(49, 20);
            this.setTempBox.TabIndex = 8;
            this.setTempBox.ValueChanged += new System.EventHandler(this.setTempBox_ValueChanged);
            // 
            // heaterButton
            // 
            this.heaterButton.BackColor = System.Drawing.Color.GhostWhite;
            this.heaterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heaterButton.Location = new System.Drawing.Point(375, 181);
            this.heaterButton.Name = "heaterButton";
            this.heaterButton.Size = new System.Drawing.Size(116, 33);
            this.heaterButton.TabIndex = 9;
            this.heaterButton.Text = "Heater";
            this.heaterButton.UseVisualStyleBackColor = false;
            this.heaterButton.Click += new System.EventHandler(this.heaterButton_Click);
            // 
            // fanButton
            // 
            this.fanButton.BackColor = System.Drawing.Color.GhostWhite;
            this.fanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fanButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fanButton.Location = new System.Drawing.Point(375, 226);
            this.fanButton.Name = "fanButton";
            this.fanButton.Size = new System.Drawing.Size(116, 33);
            this.fanButton.TabIndex = 10;
            this.fanButton.Text = "Fan";
            this.fanButton.UseVisualStyleBackColor = false;
            this.fanButton.Click += new System.EventHandler(this.fanButton_Click);
            // 
            // controllerRunButton
            // 
            this.controllerRunButton.BackColor = System.Drawing.Color.GhostWhite;
            this.controllerRunButton.Location = new System.Drawing.Point(201, 246);
            this.controllerRunButton.Name = "controllerRunButton";
            this.controllerRunButton.Size = new System.Drawing.Size(75, 23);
            this.controllerRunButton.TabIndex = 11;
            this.controllerRunButton.Text = "Start";
            this.controllerRunButton.UseVisualStyleBackColor = false;
            this.controllerRunButton.Click += new System.EventHandler(this.ControllerRunButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Temperature Setpoint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Use as Controller Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Temperature Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sensor 1";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sensor 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sensor 3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // filterTypeCombo
            // 
            this.filterTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeCombo.Items.AddRange(new object[] {
            "Average",
            "Linear (Ramp)",
            "Custom"});
            this.filterTypeCombo.Location = new System.Drawing.Point(644, 192);
            this.filterTypeCombo.Name = "filterTypeCombo";
            this.filterTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.filterTypeCombo.TabIndex = 20;
            this.filterTypeCombo.SelectedIndexChanged += new System.EventHandler(this.filterTypeCombo_SelectedIndexChanged);
            // 
            // filterLengthUpDown
            // 
            this.filterLengthUpDown.Location = new System.Drawing.Point(710, 219);
            this.filterLengthUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.filterLengthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.filterLengthUpDown.Name = "filterLengthUpDown";
            this.filterLengthUpDown.Size = new System.Drawing.Size(55, 20);
            this.filterLengthUpDown.TabIndex = 21;
            this.filterLengthUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Filter Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Filter Length:";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // filterUpdateButton
            // 
            this.filterUpdateButton.BackColor = System.Drawing.Color.GhostWhite;
            this.filterUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterUpdateButton.Location = new System.Drawing.Point(690, 245);
            this.filterUpdateButton.Name = "filterUpdateButton";
            this.filterUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.filterUpdateButton.TabIndex = 24;
            this.filterUpdateButton.Text = "Update Filter";
            this.filterUpdateButton.UseVisualStyleBackColor = false;
            this.filterUpdateButton.Click += new System.EventHandler(this.filterUpdateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(770, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 22);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // kpUpDown
            // 
            this.kpUpDown.DecimalPlaces = 2;
            this.kpUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kpUpDown.Location = new System.Drawing.Point(88, 192);
            this.kpUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kpUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.kpUpDown.Name = "kpUpDown";
            this.kpUpDown.Size = new System.Drawing.Size(43, 20);
            this.kpUpDown.TabIndex = 26;
            this.kpUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kpUpDown.ValueChanged += new System.EventHandler(this.kpUpDown_ValueChanged);
            // 
            // kiUpDown
            // 
            this.kiUpDown.DecimalPlaces = 2;
            this.kiUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.kiUpDown.Location = new System.Drawing.Point(88, 218);
            this.kiUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kiUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.kiUpDown.Name = "kiUpDown";
            this.kiUpDown.Size = new System.Drawing.Size(43, 20);
            this.kiUpDown.TabIndex = 27;
            this.kiUpDown.ValueChanged += new System.EventHandler(this.kiUpDown_ValueChanged);
            // 
            // kdUpDown
            // 
            this.kdUpDown.DecimalPlaces = 2;
            this.kdUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kdUpDown.Location = new System.Drawing.Point(88, 244);
            this.kdUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kdUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.kdUpDown.Name = "kdUpDown";
            this.kdUpDown.Size = new System.Drawing.Size(43, 20);
            this.kdUpDown.TabIndex = 28;
            this.kdUpDown.ValueChanged += new System.EventHandler(this.kdUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "P Gain";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "I Gain";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "D Gain";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(233, 192);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(233, 218);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown2.TabIndex = 33;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Fan Hysteresis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(137, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Heater Hysteresis";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(103, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Controller Settings";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(554, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Ambient Temperature";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // ambientTempDisplay
            // 
            this.ambientTempDisplay.Location = new System.Drawing.Point(533, 94);
            this.ambientTempDisplay.Name = "ambientTempDisplay";
            this.ambientTempDisplay.Size = new System.Drawing.Size(49, 20);
            this.ambientTempDisplay.TabIndex = 38;
            this.ambientTempDisplay.Text = "0";
            // 
            // setTempLabel
            // 
            this.setTempLabel.AutoSize = true;
            this.setTempLabel.Location = new System.Drawing.Point(752, 97);
            this.setTempLabel.Name = "setTempLabel";
            this.setTempLabel.Size = new System.Drawing.Size(13, 13);
            this.setTempLabel.TabIndex = 39;
            this.setTempLabel.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(669, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "+";
            // 
            // controllerInputTemp
            // 
            this.controllerInputTemp.Location = new System.Drawing.Point(389, 94);
            this.controllerInputTemp.Name = "controllerInputTemp";
            this.controllerInputTemp.Size = new System.Drawing.Size(46, 20);
            this.controllerInputTemp.TabIndex = 41;
            this.controllerInputTemp.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(376, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Controller Input";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Reacquire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterBindingSource
            // 
            this.filterBindingSource.DataSource = typeof(_313ass2.Filter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(641, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Filter Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(805, 311);
            this.ControlBox = false;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.controllerInputTemp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.setTempLabel);
            this.Controls.Add(this.ambientTempDisplay);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kdUpDown);
            this.Controls.Add(this.kiUpDown);
            this.Controls.Add(this.kpUpDown);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.filterUpdateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filterLengthUpDown);
            this.Controls.Add(this.filterTypeCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controllerRunButton);
            this.Controls.Add(this.fanButton);
            this.Controls.Add(this.heaterButton);
            this.Controls.Add(this.setTempBox);
            this.Controls.Add(this.temp3CheckBox);
            this.Controls.Add(this.temp2CheckBox);
            this.Controls.Add(this.temp1CheckBox);
            this.Controls.Add(this.temperature3);
            this.Controls.Add(this.temperature2);
            this.Controls.Add(this.temperature1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Chamber Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFilterConfigToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem openLogfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFilterConfigToolStripMenuItem;
        private System.Windows.Forms.TextBox temperature1;
        private System.Windows.Forms.TextBox temperature2;
        private System.Windows.Forms.TextBox temperature3;
        private System.Windows.Forms.CheckBox temp1CheckBox;
        private System.Windows.Forms.CheckBox temp2CheckBox;
        private System.Windows.Forms.CheckBox temp3CheckBox;
        private System.Windows.Forms.NumericUpDown setTempBox;
        private System.Windows.Forms.Button controllerRunButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button heaterButton;
        public System.Windows.Forms.Button fanButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox filterTypeCombo;
        private System.Windows.Forms.NumericUpDown filterLengthUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button filterUpdateButton;
        private System.Windows.Forms.BindingSource filterBindingSource;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.NumericUpDown kpUpDown;
        private System.Windows.Forms.NumericUpDown kiUpDown;
        private System.Windows.Forms.NumericUpDown kdUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ambientTempDisplay;
        private System.Windows.Forms.Label setTempLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox controllerInputTemp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
    }
}

