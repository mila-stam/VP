namespace Airports
{
    partial class DestinationForm
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
            this.tbNameDest = new System.Windows.Forms.TextBox();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOkD = new System.Windows.Forms.Button();
            this.btnCancelD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNameDest
            // 
            this.tbNameDest.Location = new System.Drawing.Point(61, 93);
            this.tbNameDest.Name = "tbNameDest";
            this.tbNameDest.Size = new System.Drawing.Size(216, 22);
            this.tbNameDest.TabIndex = 0;
            this.tbNameDest.Validating += new System.ComponentModel.CancelEventHandler(this.tbNameDest_Validating);
            // 
            // nudDistance
            // 
            this.nudDistance.Location = new System.Drawing.Point(70, 228);
            this.nudDistance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(120, 22);
            this.nudDistance.TabIndex = 1;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(295, 228);
            this.nudPrice.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 22);
            this.nudPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // btnOkD
            // 
            this.btnOkD.Location = new System.Drawing.Point(70, 351);
            this.btnOkD.Name = "btnOkD";
            this.btnOkD.Size = new System.Drawing.Size(75, 23);
            this.btnOkD.TabIndex = 6;
            this.btnOkD.Text = "OK";
            this.btnOkD.UseVisualStyleBackColor = true;
            this.btnOkD.Click += new System.EventHandler(this.btnOkD_Click);
            // 
            // btnCancelD
            // 
            this.btnCancelD.Location = new System.Drawing.Point(295, 351);
            this.btnCancelD.Name = "btnCancelD";
            this.btnCancelD.Size = new System.Drawing.Size(75, 23);
            this.btnCancelD.TabIndex = 7;
            this.btnCancelD.Text = "Cancel";
            this.btnCancelD.UseVisualStyleBackColor = true;
            this.btnCancelD.Click += new System.EventHandler(this.btnCancelD_Click);
            // 
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 416);
            this.Controls.Add(this.btnCancelD);
            this.Controls.Add(this.btnOkD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.tbNameDest);
            this.Name = "DestinationForm";
            this.Text = "DestinationForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameDest;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOkD;
        private System.Windows.Forms.Button btnCancelD;
    }
}