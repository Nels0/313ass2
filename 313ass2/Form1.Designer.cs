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
            this.label16 = new System.Windows.Forms.Label();
            this.ambientTempDisplay = new System.Windows.Forms.TextBox();
            this.setTempLabel = new System.Windows.Forms.Label();
            this.controllerInputTemp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1172, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogfilesToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openLogfilesToolStripMenuItem
            // 
            this.openLogfilesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openLogfilesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openLogfilesToolStripMenuItem.Name = "openLogfilesToolStripMenuItem";
            this.openLogfilesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openLogfilesToolStripMenuItem.Text = "&Open Logfiles";
            this.openLogfilesToolStripMenuItem.Click += new System.EventHandler(this.openLogfilesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFilterConfigToolStripMenuItem,
            this.loadFilterConfigToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.editToolStripMenuItem.Text = "&Filter";
            // 
            // saveFilterConfigToolStripMenuItem
            // 
            this.saveFilterConfigToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveFilterConfigToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveFilterConfigToolStripMenuItem.Name = "saveFilterConfigToolStripMenuItem";
            this.saveFilterConfigToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.saveFilterConfigToolStripMenuItem.Text = "&Save Filter Config";
            this.saveFilterConfigToolStripMenuItem.Click += new System.EventHandler(this.saveFilterConfigToolStripMenuItem_Click);
            // 
            // loadFilterConfigToolStripMenuItem
            // 
            this.loadFilterConfigToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadFilterConfigToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadFilterConfigToolStripMenuItem.Name = "loadFilterConfigToolStripMenuItem";
            this.loadFilterConfigToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.loadFilterConfigToolStripMenuItem.Text = "&Load Custom Filter Config";
            this.loadFilterConfigToolStripMenuItem.Click += new System.EventHandler(this.loadFilterConfigToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 744);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1172, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // temperature1
            // 
            this.temperature1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temperature1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperature1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temperature1.Location = new System.Drawing.Point(60, 93);
            this.temperature1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperature1.Name = "temperature1";
            this.temperature1.Size = new System.Drawing.Size(63, 22);
            this.temperature1.TabIndex = 2;
            this.temperature1.Text = "0";
            this.temperature1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temperature2
            // 
            this.temperature2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temperature2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperature2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temperature2.Location = new System.Drawing.Point(196, 93);
            this.temperature2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperature2.Name = "temperature2";
            this.temperature2.Size = new System.Drawing.Size(62, 22);
            this.temperature2.TabIndex = 3;
            this.temperature2.Text = "0";
            this.temperature2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temperature3
            // 
            this.temperature3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temperature3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperature3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temperature3.Location = new System.Drawing.Point(325, 93);
            this.temperature3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperature3.Name = "temperature3";
            this.temperature3.Size = new System.Drawing.Size(62, 22);
            this.temperature3.TabIndex = 4;
            this.temperature3.Text = "0";
            this.temperature3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temperature3.TextChanged += new System.EventHandler(this.Temperature3_TextChanged);
            // 
            // temp1CheckBox
            // 
            this.temp1CheckBox.AutoSize = true;
            this.temp1CheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temp1CheckBox.Checked = true;
            this.temp1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temp1CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp1CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.temp1CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp1CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temp1CheckBox.Location = new System.Drawing.Point(131, 98);
            this.temp1CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temp1CheckBox.Name = "temp1CheckBox";
            this.temp1CheckBox.Size = new System.Drawing.Size(14, 13);
            this.temp1CheckBox.TabIndex = 5;
            this.temp1CheckBox.UseVisualStyleBackColor = false;
            this.temp1CheckBox.CheckedChanged += new System.EventHandler(this.Temp1CheckBox_CheckedChanged);
            // 
            // temp2CheckBox
            // 
            this.temp2CheckBox.AutoSize = true;
            this.temp2CheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temp2CheckBox.Checked = true;
            this.temp2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temp2CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp2CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.temp2CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp2CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temp2CheckBox.Location = new System.Drawing.Point(266, 98);
            this.temp2CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temp2CheckBox.Name = "temp2CheckBox";
            this.temp2CheckBox.Size = new System.Drawing.Size(14, 13);
            this.temp2CheckBox.TabIndex = 6;
            this.temp2CheckBox.UseVisualStyleBackColor = false;
            // 
            // temp3CheckBox
            // 
            this.temp3CheckBox.AutoSize = true;
            this.temp3CheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temp3CheckBox.Checked = true;
            this.temp3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temp3CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp3CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.temp3CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp3CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.temp3CheckBox.Location = new System.Drawing.Point(395, 98);
            this.temp3CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temp3CheckBox.Name = "temp3CheckBox";
            this.temp3CheckBox.Size = new System.Drawing.Size(14, 13);
            this.temp3CheckBox.TabIndex = 7;
            this.temp3CheckBox.UseVisualStyleBackColor = false;
            // 
            // setTempBox
            // 
            this.setTempBox.AllowDrop = true;
            this.setTempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setTempBox.DecimalPlaces = 1;
            this.setTempBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.setTempBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.setTempBox.Location = new System.Drawing.Point(266, 236);
            this.setTempBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setTempBox.Name = "setTempBox";
            this.setTempBox.Size = new System.Drawing.Size(138, 22);
            this.setTempBox.TabIndex = 8;
            this.setTempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setTempBox.ValueChanged += new System.EventHandler(this.setTempBox_ValueChanged);
            // 
            // heaterButton
            // 
            this.heaterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heaterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heaterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heaterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heaterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heaterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.heaterButton.Location = new System.Drawing.Point(423, 163);
            this.heaterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heaterButton.Name = "heaterButton";
            this.heaterButton.Size = new System.Drawing.Size(155, 41);
            this.heaterButton.TabIndex = 9;
            this.heaterButton.Text = "Heater";
            this.heaterButton.UseVisualStyleBackColor = false;
            this.heaterButton.Click += new System.EventHandler(this.heaterButton_Click);
            // 
            // fanButton
            // 
            this.fanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fanButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.fanButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.fanButton.Location = new System.Drawing.Point(586, 163);
            this.fanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fanButton.Name = "fanButton";
            this.fanButton.Size = new System.Drawing.Size(155, 41);
            this.fanButton.TabIndex = 10;
            this.fanButton.Text = "Fan";
            this.fanButton.UseVisualStyleBackColor = false;
            this.fanButton.Click += new System.EventHandler(this.fanButton_Click);
            // 
            // controllerRunButton
            // 
            this.controllerRunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controllerRunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controllerRunButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controllerRunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controllerRunButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.controllerRunButton.Location = new System.Drawing.Point(369, 134);
            this.controllerRunButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controllerRunButton.Name = "controllerRunButton";
            this.controllerRunButton.Size = new System.Drawing.Size(73, 28);
            this.controllerRunButton.TabIndex = 11;
            this.controllerRunButton.Text = "Start";
            this.controllerRunButton.UseVisualStyleBackColor = false;
            this.controllerRunButton.Click += new System.EventHandler(this.ControllerRunButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(263, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Setpoint";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(67, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sensor 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(202, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sensor 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label7.Location = new System.Drawing.Point(330, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sensor 3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // filterTypeCombo
            // 
            this.filterTypeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.filterTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterTypeCombo.Items.AddRange(new object[] {
            "Average",
            "Linear (Ramp)",
            "Custom"});
            this.filterTypeCombo.Location = new System.Drawing.Point(165, 43);
            this.filterTypeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterTypeCombo.Name = "filterTypeCombo";
            this.filterTypeCombo.Size = new System.Drawing.Size(160, 24);
            this.filterTypeCombo.TabIndex = 20;
            this.filterTypeCombo.SelectedIndexChanged += new System.EventHandler(this.filterTypeCombo_SelectedIndexChanged);
            // 
            // filterLengthUpDown
            // 
            this.filterLengthUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.filterLengthUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterLengthUpDown.Location = new System.Drawing.Point(165, 83);
            this.filterLengthUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.filterLengthUpDown.Size = new System.Drawing.Size(161, 22);
            this.filterLengthUpDown.TabIndex = 21;
            this.filterLengthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filterLengthUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label8.Location = new System.Drawing.Point(36, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Filter Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label9.Location = new System.Drawing.Point(36, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
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
            this.filterUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterUpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.filterUpdateButton.Location = new System.Drawing.Point(369, 96);
            this.filterUpdateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterUpdateButton.Name = "filterUpdateButton";
            this.filterUpdateButton.Size = new System.Drawing.Size(73, 28);
            this.filterUpdateButton.TabIndex = 24;
            this.filterUpdateButton.Text = "Update Filter";
            this.filterUpdateButton.UseVisualStyleBackColor = false;
            this.filterUpdateButton.Click += new System.EventHandler(this.filterUpdateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1139, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 28);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // kpUpDown
            // 
            this.kpUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kpUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kpUpDown.DecimalPlaces = 2;
            this.kpUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kpUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kpUpDown.Location = new System.Drawing.Point(126, 46);
            this.kpUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.kpUpDown.Size = new System.Drawing.Size(62, 18);
            this.kpUpDown.TabIndex = 26;
            this.kpUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kpUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kpUpDown.ValueChanged += new System.EventHandler(this.kpUpDown_ValueChanged);
            // 
            // kiUpDown
            // 
            this.kiUpDown.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.kiUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kiUpDown.DecimalPlaces = 2;
            this.kiUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kiUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.kiUpDown.Location = new System.Drawing.Point(126, 81);
            this.kiUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.kiUpDown.Size = new System.Drawing.Size(62, 18);
            this.kiUpDown.TabIndex = 27;
            this.kiUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kiUpDown.ValueChanged += new System.EventHandler(this.kiUpDown_ValueChanged);
            // 
            // kdUpDown
            // 
            this.kdUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kdUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kdUpDown.DecimalPlaces = 2;
            this.kdUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kdUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kdUpDown.Location = new System.Drawing.Point(126, 115);
            this.kdUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.kdUpDown.Size = new System.Drawing.Size(62, 18);
            this.kdUpDown.TabIndex = 28;
            this.kdUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kdUpDown.ValueChanged += new System.EventHandler(this.kdUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label10.Location = new System.Drawing.Point(36, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "P Gain";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label11.Location = new System.Drawing.Point(36, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "I Gain";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label12.Location = new System.Drawing.Point(36, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "D Gain";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(378, 45);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numericUpDown1.Size = new System.Drawing.Size(62, 18);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(378, 81);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numericUpDown2.Size = new System.Drawing.Size(62, 18);
            this.numericUpDown2.TabIndex = 33;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label13.Location = new System.Drawing.Point(223, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Fan Hysteresis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label14.Location = new System.Drawing.Point(223, 80);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "Heater Hysteresis";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label16.Location = new System.Drawing.Point(57, 214);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Ambient Temperature";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // ambientTempDisplay
            // 
            this.ambientTempDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ambientTempDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ambientTempDisplay.Location = new System.Drawing.Point(60, 235);
            this.ambientTempDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ambientTempDisplay.Name = "ambientTempDisplay";
            this.ambientTempDisplay.Size = new System.Drawing.Size(138, 22);
            this.ambientTempDisplay.TabIndex = 38;
            this.ambientTempDisplay.Text = "0";
            this.ambientTempDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setTempLabel
            // 
            this.setTempLabel.AutoSize = true;
            this.setTempLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.setTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.setTempLabel.Location = new System.Drawing.Point(183, 290);
            this.setTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.setTempLabel.Name = "setTempLabel";
            this.setTempLabel.Size = new System.Drawing.Size(19, 20);
            this.setTempLabel.TabIndex = 39;
            this.setTempLabel.Text = "0";
            // 
            // controllerInputTemp
            // 
            this.controllerInputTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.controllerInputTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controllerInputTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controllerInputTemp.Location = new System.Drawing.Point(60, 166);
            this.controllerInputTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controllerInputTemp.Name = "controllerInputTemp";
            this.controllerInputTemp.Size = new System.Drawing.Size(344, 22);
            this.controllerInputTemp.TabIndex = 41;
            this.controllerInputTemp.Text = "0";
            this.controllerInputTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label17.Location = new System.Drawing.Point(57, 145);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "Controller Input";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.button1.Location = new System.Drawing.Point(383, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 43;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(453, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 45;
            this.label1.Text = "CHAMBER CONTROLLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.ambientTempDisplay);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.controllerInputTemp);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.setTempBox);
            this.groupBox1.Controls.Add(this.setTempLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.temperature3);
            this.groupBox1.Controls.Add(this.temperature2);
            this.groupBox1.Controls.Add(this.temp3CheckBox);
            this.groupBox1.Controls.Add(this.temperature1);
            this.groupBox1.Controls.Add(this.temp2CheckBox);
            this.groupBox1.Controls.Add(this.temp1CheckBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(87, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 366);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Readings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.controllerRunButton);
            this.groupBox2.Controls.Add(this.kpUpDown);
            this.groupBox2.Controls.Add(this.kiUpDown);
            this.groupBox2.Controls.Add(this.kdUpDown);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(608, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 188);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(134)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(57, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Set Temperature:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.filterTypeCombo);
            this.groupBox3.Controls.Add(this.filterLengthUpDown);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.filterUpdateButton);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(608, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 152);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1172, 766);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fanButton);
            this.Controls.Add(this.heaterButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ambientTempDisplay;
        private System.Windows.Forms.Label setTempLabel;
        private System.Windows.Forms.TextBox controllerInputTemp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

