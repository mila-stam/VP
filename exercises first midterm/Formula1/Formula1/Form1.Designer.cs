namespace Formula1
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
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lbDrivers = new System.Windows.Forms.ListBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.lbLaps = new System.Windows.Forms.ListBox();
            this.gbDrivers = new System.Windows.Forms.GroupBox();
            this.gbLaps = new System.Windows.Forms.GroupBox();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBestLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddLap = new System.Windows.Forms.Button();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.gbDrivers.SuspendLayout();
            this.gbLaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(16, 206);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(53, 16);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "Minutes";
            // 
            // lbDrivers
            // 
            this.lbDrivers.FormattingEnabled = true;
            this.lbDrivers.ItemHeight = 16;
            this.lbDrivers.Location = new System.Drawing.Point(6, 24);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(284, 260);
            this.lbDrivers.TabIndex = 1;
            this.lbDrivers.SelectedIndexChanged += new System.EventHandler(this.lbDrivers_SelectedIndexChanged);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(6, 301);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(284, 23);
            this.btnAddDriver.TabIndex = 2;
            this.btnAddDriver.Text = "Add driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(17, 225);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(54, 22);
            this.nudMinutes.TabIndex = 3;
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(6, 347);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(284, 23);
            this.btnDeleteDriver.TabIndex = 4;
            this.btnDeleteDriver.Text = "Delete driver";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // lbLaps
            // 
            this.lbLaps.FormattingEnabled = true;
            this.lbLaps.ItemHeight = 16;
            this.lbLaps.Location = new System.Drawing.Point(6, 24);
            this.lbLaps.Name = "lbLaps";
            this.lbLaps.Size = new System.Drawing.Size(281, 164);
            this.lbLaps.TabIndex = 5;
            // 
            // gbDrivers
            // 
            this.gbDrivers.Controls.Add(this.lbDrivers);
            this.gbDrivers.Controls.Add(this.btnAddDriver);
            this.gbDrivers.Controls.Add(this.btnDeleteDriver);
            this.gbDrivers.Location = new System.Drawing.Point(12, 28);
            this.gbDrivers.Name = "gbDrivers";
            this.gbDrivers.Size = new System.Drawing.Size(296, 393);
            this.gbDrivers.TabIndex = 6;
            this.gbDrivers.TabStop = false;
            this.gbDrivers.Text = "Drivers";
            // 
            // gbLaps
            // 
            this.gbLaps.Controls.Add(this.nudTime);
            this.gbLaps.Controls.Add(this.label4);
            this.gbLaps.Controls.Add(this.tbBestLap);
            this.gbLaps.Controls.Add(this.label3);
            this.gbLaps.Controls.Add(this.btnAddLap);
            this.gbLaps.Controls.Add(this.nudSeconds);
            this.gbLaps.Controls.Add(this.label2);
            this.gbLaps.Controls.Add(this.lblMinutes);
            this.gbLaps.Controls.Add(this.lbLaps);
            this.gbLaps.Controls.Add(this.nudMinutes);
            this.gbLaps.Location = new System.Drawing.Point(328, 28);
            this.gbLaps.Name = "gbLaps";
            this.gbLaps.Size = new System.Drawing.Size(293, 393);
            this.gbLaps.TabIndex = 5;
            this.gbLaps.TabStop = false;
            this.gbLaps.Text = "Laps";
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(19, 355);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(142, 22);
            this.nudTime.TabIndex = 11;
            this.nudTime.ValueChanged += new System.EventHandler(this.nudTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time";
            // 
            // tbBestLap
            // 
            this.tbBestLap.Location = new System.Drawing.Point(17, 287);
            this.tbBestLap.Name = "tbBestLap";
            this.tbBestLap.ReadOnly = true;
            this.tbBestLap.Size = new System.Drawing.Size(260, 22);
            this.tbBestLap.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Best Lap";
            // 
            // btnAddLap
            // 
            this.btnAddLap.Location = new System.Drawing.Point(168, 224);
            this.btnAddLap.Name = "btnAddLap";
            this.btnAddLap.Size = new System.Drawing.Size(109, 23);
            this.btnAddLap.TabIndex = 5;
            this.btnAddLap.Text = "Add lap";
            this.btnAddLap.UseVisualStyleBackColor = true;
            this.btnAddLap.Click += new System.EventHandler(this.btnAddLap_Click);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(96, 225);
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(54, 22);
            this.nudSeconds.TabIndex = 7;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.gbLaps);
            this.Controls.Add(this.gbDrivers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.gbDrivers.ResumeLayout(false);
            this.gbLaps.ResumeLayout(false);
            this.gbLaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.ListBox lbDrivers;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.ListBox lbLaps;
        private System.Windows.Forms.GroupBox gbDrivers;
        private System.Windows.Forms.GroupBox gbLaps;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBestLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddLap;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label label2;
    }
}

