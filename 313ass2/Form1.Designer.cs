﻿namespace _313ass2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.filterTypeCombo = new System.Windows.Forms.ComboBox();
            this.filterLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.filterUpdateButton = new System.Windows.Forms.Button();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // 
            // loadFilterConfigToolStripMenuItem
            // 
            this.loadFilterConfigToolStripMenuItem.Name = "loadFilterConfigToolStripMenuItem";
            this.loadFilterConfigToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.loadFilterConfigToolStripMenuItem.Text = "&Load Custom Filter Config";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // temperature1
            // 
            this.temperature1.Location = new System.Drawing.Point(231, 175);
            this.temperature1.Name = "temperature1";
            this.temperature1.Size = new System.Drawing.Size(100, 20);
            this.temperature1.TabIndex = 2;
            this.temperature1.Text = "0";
            // 
            // temperature2
            // 
            this.temperature2.Location = new System.Drawing.Point(337, 175);
            this.temperature2.Name = "temperature2";
            this.temperature2.Size = new System.Drawing.Size(100, 20);
            this.temperature2.TabIndex = 3;
            this.temperature2.Text = "0";
            // 
            // temperature3
            // 
            this.temperature3.Location = new System.Drawing.Point(443, 175);
            this.temperature3.Name = "temperature3";
            this.temperature3.Size = new System.Drawing.Size(100, 20);
            this.temperature3.TabIndex = 4;
            this.temperature3.Text = "0";
            // 
            // temp1CheckBox
            // 
            this.temp1CheckBox.AutoSize = true;
            this.temp1CheckBox.Checked = true;
            this.temp1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temp1CheckBox.Location = new System.Drawing.Point(253, 200);
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
            this.temp2CheckBox.Location = new System.Drawing.Point(368, 201);
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
            this.temp3CheckBox.Location = new System.Drawing.Point(481, 200);
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
            this.setTempBox.Location = new System.Drawing.Point(231, 234);
            this.setTempBox.Name = "setTempBox";
            this.setTempBox.Size = new System.Drawing.Size(55, 20);
            this.setTempBox.TabIndex = 8;
            this.setTempBox.ValueChanged += new System.EventHandler(this.setTempBox_ValueChanged);
            // 
            // heaterButton
            // 
            this.heaterButton.Location = new System.Drawing.Point(93, 71);
            this.heaterButton.Name = "heaterButton";
            this.heaterButton.Size = new System.Drawing.Size(75, 23);
            this.heaterButton.TabIndex = 9;
            this.heaterButton.Text = "Heater";
            this.heaterButton.UseVisualStyleBackColor = true;
            this.heaterButton.Click += new System.EventHandler(this.heaterButton_Click);
            // 
            // fanButton
            // 
            this.fanButton.Location = new System.Drawing.Point(193, 71);
            this.fanButton.Name = "fanButton";
            this.fanButton.Size = new System.Drawing.Size(75, 23);
            this.fanButton.TabIndex = 10;
            this.fanButton.Text = "Fan";
            this.fanButton.UseVisualStyleBackColor = true;
            this.fanButton.Click += new System.EventHandler(this.fanButton_Click);
            // 
            // controllerRunButton
            // 
            this.controllerRunButton.Location = new System.Drawing.Point(671, 377);
            this.controllerRunButton.Name = "controllerRunButton";
            this.controllerRunButton.Size = new System.Drawing.Size(75, 23);
            this.controllerRunButton.TabIndex = 11;
            this.controllerRunButton.Text = "Start";
            this.controllerRunButton.UseVisualStyleBackColor = true;
            this.controllerRunButton.Click += new System.EventHandler(this.ControllerRunButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chamber Controller:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Temperature Setpoint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Use as Controller Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Temperature Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sensor 1";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sensor 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sensor 3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dev0",
            "dev1",
            "dev2",
            "dev3",
            "dev4",
            "dev5",
            "dev6"});
            this.comboBox1.Location = new System.Drawing.Point(625, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // filterTypeCombo
            // 
            this.filterTypeCombo.Items.AddRange(new object[] {
            "Average",
            "Linear (Ramp)",
            "Exponential"});
            this.filterTypeCombo.Location = new System.Drawing.Point(625, 73);
            this.filterTypeCombo.Name = "filterTypeCombo";
            this.filterTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.filterTypeCombo.TabIndex = 20;
            this.filterTypeCombo.Text = "Average";
            this.filterTypeCombo.SelectedIndexChanged += new System.EventHandler(this.filterTypeCombo_SelectedIndexChanged);
            // 
            // filterLengthUpDown
            // 
            this.filterLengthUpDown.DecimalPlaces = 1;
            this.filterLengthUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.filterLengthUpDown.Location = new System.Drawing.Point(691, 100);
            this.filterLengthUpDown.Name = "filterLengthUpDown";
            this.filterLengthUpDown.Size = new System.Drawing.Size(55, 20);
            this.filterLengthUpDown.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Filter Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Filter Length:";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            // 
            // filterUpdateButton
            // 
            this.filterUpdateButton.Location = new System.Drawing.Point(671, 126);
            this.filterUpdateButton.Name = "filterUpdateButton";
            this.filterUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.filterUpdateButton.TabIndex = 24;
            this.filterUpdateButton.Text = "Update Filter";
            this.filterUpdateButton.UseVisualStyleBackColor = true;
            this.filterUpdateButton.Click += new System.EventHandler(this.filterUpdateButton_Click);
            // 
            // filterBindingSource
            // 
            this.filterBindingSource.DataSource = typeof(_313ass2.Filter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterUpdateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filterLengthUpDown);
            this.Controls.Add(this.filterTypeCombo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chamber Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLengthUpDown)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button heaterButton;
        public System.Windows.Forms.Button fanButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox filterTypeCombo;
        private System.Windows.Forms.NumericUpDown filterLengthUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button filterUpdateButton;
        private System.Windows.Forms.BindingSource filterBindingSource;
    }
}

