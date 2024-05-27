namespace Airports
{
    partial class AirportForm
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
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbShort = new System.Windows.Forms.TextBox();
            this.tbNameAirport = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.btnOkA = new System.Windows.Forms.Button();
            this.btnCancelA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(62, 64);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(338, 22);
            this.tbCity.TabIndex = 0;
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbCity_Validating);
            // 
            // tbShort
            // 
            this.tbShort.Location = new System.Drawing.Point(62, 270);
            this.tbShort.Name = "tbShort";
            this.tbShort.Size = new System.Drawing.Size(338, 22);
            this.tbShort.TabIndex = 1;
            this.tbShort.Validating += new System.ComponentModel.CancelEventHandler(this.tbShort_Validating);
            // 
            // tbNameAirport
            // 
            this.tbNameAirport.Location = new System.Drawing.Point(62, 166);
            this.tbNameAirport.Name = "tbNameAirport";
            this.tbNameAirport.Size = new System.Drawing.Size(338, 22);
            this.tbNameAirport.TabIndex = 2;
            this.tbNameAirport.Validating += new System.ComponentModel.CancelEventHandler(this.tbNameAirport_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 138);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(59, 36);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(59, 241);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(78, 16);
            this.lblShort.TabIndex = 5;
            this.lblShort.Text = "Short Name";
            // 
            // btnOkA
            // 
            this.btnOkA.Location = new System.Drawing.Point(62, 359);
            this.btnOkA.Name = "btnOkA";
            this.btnOkA.Size = new System.Drawing.Size(75, 23);
            this.btnOkA.TabIndex = 6;
            this.btnOkA.Text = "OK";
            this.btnOkA.UseVisualStyleBackColor = true;
            this.btnOkA.Click += new System.EventHandler(this.btnOkA_Click);
            // 
            // btnCancelA
            // 
            this.btnCancelA.Location = new System.Drawing.Point(325, 359);
            this.btnCancelA.Name = "btnCancelA";
            this.btnCancelA.Size = new System.Drawing.Size(75, 23);
            this.btnCancelA.TabIndex = 7;
            this.btnCancelA.Text = "Cancel";
            this.btnCancelA.UseVisualStyleBackColor = true;
            this.btnCancelA.Click += new System.EventHandler(this.btnCancelA_Click);
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.btnCancelA);
            this.Controls.Add(this.btnOkA);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbNameAirport);
            this.Controls.Add(this.tbShort);
            this.Controls.Add(this.tbCity);
            this.Name = "AirportForm";
            this.Text = "AirportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbShort;
        private System.Windows.Forms.TextBox tbNameAirport;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Button btnOkA;
        private System.Windows.Forms.Button btnCancelA;
    }
}