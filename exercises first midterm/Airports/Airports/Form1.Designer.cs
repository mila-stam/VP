namespace Airports
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
            this.btnAddNewAirport = new System.Windows.Forms.Button();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddNewDestination = new System.Windows.Forms.Button();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNewAirport
            // 
            this.btnAddNewAirport.Location = new System.Drawing.Point(70, 278);
            this.btnAddNewAirport.Name = "btnAddNewAirport";
            this.btnAddNewAirport.Size = new System.Drawing.Size(138, 37);
            this.btnAddNewAirport.TabIndex = 0;
            this.btnAddNewAirport.Text = "add new airport";
            this.btnAddNewAirport.UseVisualStyleBackColor = true;
            this.btnAddNewAirport.Click += new System.EventHandler(this.btnAddNewAirport_Click);
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 16;
            this.lbAirports.Location = new System.Drawing.Point(23, 22);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(231, 228);
            this.lbAirports.TabIndex = 1;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            this.lbAirports.SelectedValueChanged += new System.EventHandler(this.lbAirports_SelectedValueChanged);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(71, 341);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(138, 37);
            this.btnDeleteAirport.TabIndex = 2;
            this.btnDeleteAirport.Text = "delete airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddNewDestination
            // 
            this.btnAddNewDestination.Location = new System.Drawing.Point(70, 400);
            this.btnAddNewDestination.Name = "btnAddNewDestination";
            this.btnAddNewDestination.Size = new System.Drawing.Size(148, 37);
            this.btnAddNewDestination.TabIndex = 3;
            this.btnAddNewDestination.Text = "add new destination";
            this.btnAddNewDestination.UseVisualStyleBackColor = true;
            this.btnAddNewDestination.Click += new System.EventHandler(this.btnAddNewDestination_Click);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 16;
            this.lbDestinations.Location = new System.Drawing.Point(285, 22);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(231, 228);
            this.lbDestinations.TabIndex = 4;
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(296, 348);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(202, 22);
            this.tbAverage.TabIndex = 5;
            // 
            // tbMostExpensiveDestination
            // 
            this.tbMostExpensiveDestination.Location = new System.Drawing.Point(296, 293);
            this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
            this.tbMostExpensiveDestination.ReadOnly = true;
            this.tbMostExpensiveDestination.Size = new System.Drawing.Size(202, 22);
            this.tbMostExpensiveDestination.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Most expensive destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Average distance for destinations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMostExpensiveDestination);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.btnAddNewDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.btnAddNewAirport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewAirport;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddNewDestination;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbMostExpensiveDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

