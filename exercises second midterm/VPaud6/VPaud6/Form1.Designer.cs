namespace VPaud6
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
            this.tbWordState = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnTryLetter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuessedLetters = new System.Windows.Forms.TextBox();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.pbWrongTries = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbWordState
            // 
            this.tbWordState.Location = new System.Drawing.Point(45, 102);
            this.tbWordState.Name = "tbWordState";
            this.tbWordState.ReadOnly = true;
            this.tbWordState.Size = new System.Drawing.Size(520, 22);
            this.tbWordState.TabIndex = 0;
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(524, 36);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(77, 22);
            this.tbTimer.TabIndex = 1;
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(52, 177);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(109, 22);
            this.tbLetter.TabIndex = 2;
            // 
            // btnTryLetter
            // 
            this.btnTryLetter.Location = new System.Drawing.Point(186, 177);
            this.btnTryLetter.Name = "btnTryLetter";
            this.btnTryLetter.Size = new System.Drawing.Size(75, 23);
            this.btnTryLetter.TabIndex = 3;
            this.btnTryLetter.Text = "OK";
            this.btnTryLetter.UseVisualStyleBackColor = true;
            this.btnTryLetter.Click += new System.EventHandler(this.btnTryLetter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // tbGuessedLetters
            // 
            this.tbGuessedLetters.Location = new System.Drawing.Point(45, 273);
            this.tbGuessedLetters.Name = "tbGuessedLetters";
            this.tbGuessedLetters.ReadOnly = true;
            this.tbGuessedLetters.Size = new System.Drawing.Size(553, 22);
            this.tbGuessedLetters.TabIndex = 5;
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(45, 388);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(553, 39);
            this.pbTimer.TabIndex = 6;
            // 
            // pbWrongTries
            // 
            this.pbWrongTries.Location = new System.Drawing.Point(45, 326);
            this.pbWrongTries.Name = "pbWrongTries";
            this.pbWrongTries.Size = new System.Drawing.Size(553, 39);
            this.pbWrongTries.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 477);
            this.Controls.Add(this.pbWrongTries);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.tbGuessedLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTryLetter);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.tbWordState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWordState;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnTryLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGuessedLetters;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.ProgressBar pbWrongTries;
        private System.Windows.Forms.Timer timer1;
    }
}

