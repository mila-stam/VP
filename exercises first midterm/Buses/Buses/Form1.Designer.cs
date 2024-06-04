namespace Buses
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBuses = new System.Windows.Forms.ListBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.gbLines = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.gbLines.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buses";
            // 
            // lbBuses
            // 
            this.lbBuses.FormattingEnabled = true;
            this.lbBuses.ItemHeight = 16;
            this.lbBuses.Location = new System.Drawing.Point(15, 43);
            this.lbBuses.Name = "lbBuses";
            this.lbBuses.Size = new System.Drawing.Size(227, 244);
            this.lbBuses.TabIndex = 1;
            this.lbBuses.SelectedIndexChanged += new System.EventHandler(this.lbBuses_SelectedIndexChanged);
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(15, 311);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(227, 23);
            this.btnAddBus.TabIndex = 2;
            this.btnAddBus.Text = "Add bus";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Location = new System.Drawing.Point(15, 350);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(227, 23);
            this.btnDeleteBus.TabIndex = 3;
            this.btnDeleteBus.Text = "Delete Bus";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(15, 388);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(227, 23);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Add line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lines";
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.ItemHeight = 16;
            this.lbLines.Location = new System.Drawing.Point(291, 43);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(227, 244);
            this.lbLines.TabIndex = 6;
            // 
            // gbLines
            // 
            this.gbLines.Controls.Add(this.tbAverage);
            this.gbLines.Controls.Add(this.label4);
            this.gbLines.Controls.Add(this.tbMostExpensive);
            this.gbLines.Controls.Add(this.label3);
            this.gbLines.Location = new System.Drawing.Point(291, 311);
            this.gbLines.Name = "gbLines";
            this.gbLines.Size = new System.Drawing.Size(227, 127);
            this.gbLines.TabIndex = 7;
            this.gbLines.TabStop = false;
            this.gbLines.Text = "Lines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Most expensive line";
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Location = new System.Drawing.Point(9, 46);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.ReadOnly = true;
            this.tbMostExpensive.Size = new System.Drawing.Size(212, 22);
            this.tbMostExpensive.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average price of the lines";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(9, 99);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAverage.Size = new System.Drawing.Size(212, 22);
            this.tbAverage.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.gbLines);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.lbBuses);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLines.ResumeLayout(false);
            this.gbLines.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBuses;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.GroupBox gbLines;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.Label label3;
    }
}

