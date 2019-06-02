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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFilterConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilterConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempBox)).BeginInit();
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
            this.openLogfilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openLogfilesToolStripMenuItem.Text = "&Open Logfiles";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFilterConfigToolStripMenuItem,
            this.saveFilterConfigToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.editToolStripMenuItem.Text = "&Filter";
            // 
            // loadFilterConfigToolStripMenuItem
            // 
            this.loadFilterConfigToolStripMenuItem.Name = "loadFilterConfigToolStripMenuItem";
            this.loadFilterConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFilterConfigToolStripMenuItem.Text = "&Load Filter Config";
            // 
            // saveFilterConfigToolStripMenuItem
            // 
            this.saveFilterConfigToolStripMenuItem.Name = "saveFilterConfigToolStripMenuItem";
            this.saveFilterConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFilterConfigToolStripMenuItem.Text = "&Save Filter Config";
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
            // 
            // temperature2
            // 
            this.temperature2.Location = new System.Drawing.Point(337, 175);
            this.temperature2.Name = "temperature2";
            this.temperature2.Size = new System.Drawing.Size(100, 20);
            this.temperature2.TabIndex = 3;
            // 
            // temperature3
            // 
            this.temperature3.Location = new System.Drawing.Point(443, 175);
            this.temperature3.Name = "temperature3";
            this.temperature3.Size = new System.Drawing.Size(100, 20);
            this.temperature3.TabIndex = 4;
            // 
            // temp1CheckBox
            // 
            this.temp1CheckBox.AutoSize = true;
            this.temp1CheckBox.Location = new System.Drawing.Point(253, 200);
            this.temp1CheckBox.Name = "temp1CheckBox";
            this.temp1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.temp1CheckBox.TabIndex = 5;
            this.temp1CheckBox.UseVisualStyleBackColor = true;
            // 
            // temp2CheckBox
            // 
            this.temp2CheckBox.AutoSize = true;
            this.temp2CheckBox.Location = new System.Drawing.Point(368, 201);
            this.temp2CheckBox.Name = "temp2CheckBox";
            this.temp2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.temp2CheckBox.TabIndex = 6;
            this.temp2CheckBox.UseVisualStyleBackColor = true;
            // 
            // temp3CheckBox
            // 
            this.temp3CheckBox.AutoSize = true;
            this.temp3CheckBox.Location = new System.Drawing.Point(481, 200);
            this.temp3CheckBox.Name = "temp3CheckBox";
            this.temp3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.temp3CheckBox.TabIndex = 7;
            this.temp3CheckBox.UseVisualStyleBackColor = true;
            // 
            // setTempBox
            // 
            this.setTempBox.Location = new System.Drawing.Point(231, 234);
            this.setTempBox.Name = "setTempBox";
            this.setTempBox.Size = new System.Drawing.Size(55, 20);
            this.setTempBox.TabIndex = 8;
            // 
            // heaterButton
            // 
            this.heaterButton.Location = new System.Drawing.Point(93, 71);
            this.heaterButton.Name = "heaterButton";
            this.heaterButton.Size = new System.Drawing.Size(75, 23);
            this.heaterButton.TabIndex = 9;
            this.heaterButton.Text = "Heater";
            this.heaterButton.UseVisualStyleBackColor = true;
            // 
            // fanButton
            // 
            this.fanButton.Location = new System.Drawing.Point(193, 71);
            this.fanButton.Name = "fanButton";
            this.fanButton.Size = new System.Drawing.Size(75, 23);
            this.fanButton.TabIndex = 10;
            this.fanButton.Text = "Fan";
            this.fanButton.UseVisualStyleBackColor = true;
            // 
            // controllerRunButton
            // 
            this.controllerRunButton.Location = new System.Drawing.Point(502, 267);
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
            this.label1.Location = new System.Drawing.Point(397, 272);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempBox)).EndInit();
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
        private System.Windows.Forms.Button heaterButton;
        private System.Windows.Forms.Button fanButton;
        private System.Windows.Forms.Button controllerRunButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

