namespace Buses
{
    partial class LineForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLine = new System.Windows.Forms.GroupBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            this.gbLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(31, 134);
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(100, 22);
            this.nudHour.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination:";
            // 
            // gbLine
            // 
            this.gbLine.Controls.Add(this.btnCancel);
            this.gbLine.Controls.Add(this.btnAdd);
            this.gbLine.Controls.Add(this.label4);
            this.gbLine.Controls.Add(this.nudPrice);
            this.gbLine.Controls.Add(this.label3);
            this.gbLine.Controls.Add(this.nudMinutes);
            this.gbLine.Controls.Add(this.label2);
            this.gbLine.Controls.Add(this.nudHour);
            this.gbLine.Controls.Add(this.tbDestination);
            this.gbLine.Controls.Add(this.label1);
            this.gbLine.Location = new System.Drawing.Point(23, 22);
            this.gbLine.Name = "gbLine";
            this.gbLine.Size = new System.Drawing.Size(337, 294);
            this.gbLine.TabIndex = 3;
            this.gbLine.TabStop = false;
            this.gbLine.Text = "Add line";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(20, 64);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(278, 22);
            this.tbDestination.TabIndex = 2;
            this.tbDestination.Validating += new System.ComponentModel.CancelEventHandler(this.tbDestination_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minutes";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(198, 134);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(100, 22);
            this.nudMinutes.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(30, 199);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(208, 22);
            this.nudPrice.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 328);
            this.Controls.Add(this.gbLine);
            this.Name = "LineForm";
            this.Text = "LineForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            this.gbLine.ResumeLayout(false);
            this.gbLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestination;
    }
}