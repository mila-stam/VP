namespace Buses
{
    partial class BusForm
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
            this.gbAddBus = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegistration = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLocal = new System.Windows.Forms.CheckBox();
            this.gbAddBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddBus
            // 
            this.gbAddBus.Controls.Add(this.cbLocal);
            this.gbAddBus.Controls.Add(this.label3);
            this.gbAddBus.Controls.Add(this.btnCancel);
            this.gbAddBus.Controls.Add(this.btnSave);
            this.gbAddBus.Controls.Add(this.label2);
            this.gbAddBus.Controls.Add(this.tbRegistration);
            this.gbAddBus.Controls.Add(this.label1);
            this.gbAddBus.Controls.Add(this.tbName);
            this.gbAddBus.Location = new System.Drawing.Point(23, 28);
            this.gbAddBus.Name = "gbAddBus";
            this.gbAddBus.Size = new System.Drawing.Size(388, 300);
            this.gbAddBus.TabIndex = 0;
            this.gbAddBus.TabStop = false;
            this.gbAddBus.Text = "Add Bus";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(22, 57);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(338, 22);
            this.tbName.TabIndex = 3;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registration";
            // 
            // tbRegistration
            // 
            this.tbRegistration.Location = new System.Drawing.Point(27, 139);
            this.tbRegistration.Name = "tbRegistration";
            this.tbRegistration.Size = new System.Drawing.Size(338, 22);
            this.tbRegistration.TabIndex = 5;
            this.tbRegistration.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegistration_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local";
            // 
            // cbLocal
            // 
            this.cbLocal.AutoSize = true;
            this.cbLocal.Location = new System.Drawing.Point(27, 204);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(87, 20);
            this.cbLocal.TabIndex = 8;
            this.cbLocal.Text = "Is it local?";
            this.cbLocal.UseVisualStyleBackColor = true;
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 340);
            this.Controls.Add(this.gbAddBus);
            this.Name = "BusForm";
            this.Text = "BusForm";
            this.gbAddBus.ResumeLayout(false);
            this.gbAddBus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddBus;
        private System.Windows.Forms.CheckBox cbLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
    }
}