namespace SportsBet
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
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbBilten = new System.Windows.Forms.ListBox();
            this.lbTicket = new System.Windows.Forms.ListBox();
            this.updown1 = new System.Windows.Forms.NumericUpDown();
            this.updown2 = new System.Windows.Forms.NumericUpDown();
            this.updownX = new System.Windows.Forms.NumericUpDown();
            this.coef1 = new System.Windows.Forms.Label();
            this.coefX = new System.Windows.Forms.Label();
            this.coef2 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.btnAddToBilten = new System.Windows.Forms.Button();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.lblCode1 = new System.Windows.Forms.Label();
            this.tbCode1 = new System.Windows.Forms.TextBox();
            this.ddType = new System.Windows.Forms.ComboBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.tbTotalCoef = new System.Windows.Forms.TextBox();
            this.tbTotalGain = new System.Windows.Forms.TextBox();
            this.updownPay = new System.Windows.Forms.NumericUpDown();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownPay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 16;
            this.lbTeams.Location = new System.Drawing.Point(12, 40);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTeams.Size = new System.Drawing.Size(215, 212);
            this.lbTeams.TabIndex = 1;
            // 
            // lbBilten
            // 
            this.lbBilten.FormattingEnabled = true;
            this.lbBilten.ItemHeight = 16;
            this.lbBilten.Location = new System.Drawing.Point(244, 40);
            this.lbBilten.Name = "lbBilten";
            this.lbBilten.Size = new System.Drawing.Size(215, 212);
            this.lbBilten.TabIndex = 2;
            // 
            // lbTicket
            // 
            this.lbTicket.FormattingEnabled = true;
            this.lbTicket.ItemHeight = 16;
            this.lbTicket.Location = new System.Drawing.Point(478, 40);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(215, 212);
            this.lbTicket.TabIndex = 3;
            this.lbTicket.SizeChanged += new System.EventHandler(this.lbTicket_SizeChanged);
            // 
            // updown1
            // 
            this.updown1.Location = new System.Drawing.Point(92, 291);
            this.updown1.Name = "updown1";
            this.updown1.Size = new System.Drawing.Size(120, 22);
            this.updown1.TabIndex = 4;
            // 
            // updown2
            // 
            this.updown2.Location = new System.Drawing.Point(92, 347);
            this.updown2.Name = "updown2";
            this.updown2.Size = new System.Drawing.Size(120, 22);
            this.updown2.TabIndex = 5;
            // 
            // updownX
            // 
            this.updownX.Location = new System.Drawing.Point(92, 319);
            this.updownX.Name = "updownX";
            this.updownX.Size = new System.Drawing.Size(120, 22);
            this.updownX.TabIndex = 6;
            // 
            // coef1
            // 
            this.coef1.AutoSize = true;
            this.coef1.Location = new System.Drawing.Point(25, 291);
            this.coef1.Name = "coef1";
            this.coef1.Size = new System.Drawing.Size(14, 16);
            this.coef1.TabIndex = 7;
            this.coef1.Text = "1";
            // 
            // coefX
            // 
            this.coefX.AutoSize = true;
            this.coefX.Location = new System.Drawing.Point(25, 321);
            this.coefX.Name = "coefX";
            this.coefX.Size = new System.Drawing.Size(15, 16);
            this.coefX.TabIndex = 8;
            this.coefX.Text = "X";
            // 
            // coef2
            // 
            this.coef2.AutoSize = true;
            this.coef2.Location = new System.Drawing.Point(25, 353);
            this.coef2.Name = "coef2";
            this.coef2.Size = new System.Drawing.Size(14, 16);
            this.coef2.TabIndex = 9;
            this.coef2.Text = "2";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(65, 392);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(126, 22);
            this.tbCode.TabIndex = 10;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(15, 395);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(40, 16);
            this.lbCode.TabIndex = 11;
            this.lbCode.Text = "Code";
            // 
            // btnAddToBilten
            // 
            this.btnAddToBilten.Location = new System.Drawing.Point(45, 432);
            this.btnAddToBilten.Name = "btnAddToBilten";
            this.btnAddToBilten.Size = new System.Drawing.Size(126, 23);
            this.btnAddToBilten.TabIndex = 12;
            this.btnAddToBilten.Text = "add to bilten";
            this.btnAddToBilten.UseVisualStyleBackColor = true;
            this.btnAddToBilten.Click += new System.EventHandler(this.btnAddToBilten_Click);
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(45, 472);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(126, 23);
            this.btnAddNewTeam.TabIndex = 13;
            this.btnAddNewTeam.Text = "add new team";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            this.btnAddNewTeam.Click += new System.EventHandler(this.btnAddNewTeam_Click);
            // 
            // lblCode1
            // 
            this.lblCode1.AutoSize = true;
            this.lblCode1.Location = new System.Drawing.Point(259, 318);
            this.lblCode1.Name = "lblCode1";
            this.lblCode1.Size = new System.Drawing.Size(40, 16);
            this.lblCode1.TabIndex = 15;
            this.lblCode1.Text = "Code";
            // 
            // tbCode1
            // 
            this.tbCode1.Location = new System.Drawing.Point(309, 315);
            this.tbCode1.Name = "tbCode1";
            this.tbCode1.Size = new System.Drawing.Size(126, 22);
            this.tbCode1.TabIndex = 14;
            this.tbCode1.TextChanged += new System.EventHandler(this.tbCode1_TextChanged);
            // 
            // ddType
            // 
            this.ddType.FormattingEnabled = true;
            this.ddType.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.ddType.Location = new System.Drawing.Point(262, 376);
            this.ddType.Name = "ddType";
            this.ddType.Size = new System.Drawing.Size(173, 24);
            this.ddType.TabIndex = 16;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(278, 432);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(125, 37);
            this.btnAddGame.TabIndex = 17;
            this.btnAddGame.Text = "add new game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // tbTotalCoef
            // 
            this.tbTotalCoef.Location = new System.Drawing.Point(498, 288);
            this.tbTotalCoef.Name = "tbTotalCoef";
            this.tbTotalCoef.Size = new System.Drawing.Size(172, 22);
            this.tbTotalCoef.TabIndex = 18;
            // 
            // tbTotalGain
            // 
            this.tbTotalGain.Location = new System.Drawing.Point(498, 405);
            this.tbTotalGain.Name = "tbTotalGain";
            this.tbTotalGain.Size = new System.Drawing.Size(176, 22);
            this.tbTotalGain.TabIndex = 19;
            // 
            // updownPay
            // 
            this.updownPay.Location = new System.Drawing.Point(498, 347);
            this.updownPay.Name = "updownPay";
            this.updownPay.Size = new System.Drawing.Size(172, 22);
            this.updownPay.TabIndex = 20;
            this.updownPay.ValueChanged += new System.EventHandler(this.updownPay_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(525, 445);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(125, 37);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 507);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.updownPay);
            this.Controls.Add(this.tbTotalGain);
            this.Controls.Add(this.tbTotalCoef);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.ddType);
            this.Controls.Add(this.lblCode1);
            this.Controls.Add(this.tbCode1);
            this.Controls.Add(this.btnAddNewTeam);
            this.Controls.Add(this.btnAddToBilten);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.coef2);
            this.Controls.Add(this.coefX);
            this.Controls.Add(this.coef1);
            this.Controls.Add(this.updownX);
            this.Controls.Add(this.updown2);
            this.Controls.Add(this.updown1);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.lbBilten);
            this.Controls.Add(this.lbTeams);
            this.Name = "Form1";
            this.Text = "Sports Bet";
            ((System.ComponentModel.ISupportInitialize)(this.updown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbBilten;
        private System.Windows.Forms.ListBox lbTicket;
        private System.Windows.Forms.NumericUpDown updown1;
        private System.Windows.Forms.NumericUpDown updown2;
        private System.Windows.Forms.NumericUpDown updownX;
        private System.Windows.Forms.Label coef1;
        private System.Windows.Forms.Label coefX;
        private System.Windows.Forms.Label coef2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Button btnAddToBilten;
        private System.Windows.Forms.Button btnAddNewTeam;
        private System.Windows.Forms.Label lblCode1;
        private System.Windows.Forms.TextBox tbCode1;
        private System.Windows.Forms.ComboBox ddType;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.TextBox tbTotalCoef;
        private System.Windows.Forms.TextBox tbTotalGain;
        private System.Windows.Forms.NumericUpDown updownPay;
        private System.Windows.Forms.Button btnPrint;
    }
}

