namespace PizzaOrders
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.tbSizeBig = new System.Windows.Forms.TextBox();
            this.tbSizeMid = new System.Windows.Forms.TextBox();
            this.tbSizeSmall = new System.Windows.Forms.TextBox();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.cbKetchap = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbPepers = new System.Windows.Forms.CheckBox();
            this.tbKetchap = new System.Windows.Forms.TextBox();
            this.tbExtraCheese = new System.Windows.Forms.TextBox();
            this.tbPepers = new System.Windows.Forms.TextBox();
            this.gbDrink = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbBeerTotal = new System.Windows.Forms.TextBox();
            this.tbJuiceTotal = new System.Windows.Forms.TextBox();
            this.tbFuzzyTotal = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbBeerPrice = new System.Windows.Forms.TextBox();
            this.tbJuicePrice = new System.Windows.Forms.TextBox();
            this.tbFuzzyPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBeer = new System.Windows.Forms.Label();
            this.lblJuice = new System.Windows.Forms.Label();
            this.lblFuzzyDrink = new System.Windows.Forms.Label();
            this.tbBeerQuantity = new System.Windows.Forms.TextBox();
            this.tbJuiceQuantity = new System.Windows.Forms.TextBox();
            this.tbFuzzyQuantity = new System.Windows.Forms.TextBox();
            this.gbDessert = new System.Windows.Forms.GroupBox();
            this.lbDessert = new System.Windows.Forms.ListBox();
            this.tbDessertPrice = new System.Windows.Forms.TextBox();
            this.lblDessertPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.lblTotalP = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblPayed = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.tbPayed = new System.Windows.Forms.TextBox();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.gbSize.SuspendLayout();
            this.gbExtras.SuspendLayout();
            this.gbDrink.SuspendLayout();
            this.gbDessert.SuspendLayout();
            this.gbPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.tbSizeBig);
            this.gbSize.Controls.Add(this.tbSizeMid);
            this.gbSize.Controls.Add(this.tbSizeSmall);
            this.gbSize.Controls.Add(this.rbBig);
            this.gbSize.Controls.Add(this.rbMiddle);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(12, 12);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(208, 135);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // tbSizeBig
            // 
            this.tbSizeBig.Location = new System.Drawing.Point(129, 95);
            this.tbSizeBig.Name = "tbSizeBig";
            this.tbSizeBig.Size = new System.Drawing.Size(65, 22);
            this.tbSizeBig.TabIndex = 4;
            // 
            // tbSizeMid
            // 
            this.tbSizeMid.Location = new System.Drawing.Point(129, 56);
            this.tbSizeMid.Name = "tbSizeMid";
            this.tbSizeMid.Size = new System.Drawing.Size(65, 22);
            this.tbSizeMid.TabIndex = 3;
            // 
            // tbSizeSmall
            // 
            this.tbSizeSmall.Location = new System.Drawing.Point(129, 21);
            this.tbSizeSmall.Name = "tbSizeSmall";
            this.tbSizeSmall.Size = new System.Drawing.Size(65, 22);
            this.tbSizeSmall.TabIndex = 1;
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(3, 97);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(48, 20);
            this.rbBig.TabIndex = 2;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Big";
            this.rbBig.UseVisualStyleBackColor = true;
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Location = new System.Drawing.Point(3, 57);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(69, 20);
            this.rbMiddle.TabIndex = 1;
            this.rbMiddle.TabStop = true;
            this.rbMiddle.Text = "Middle";
            this.rbMiddle.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(3, 21);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // gbExtras
            // 
            this.gbExtras.Controls.Add(this.cbKetchap);
            this.gbExtras.Controls.Add(this.cbExtraCheese);
            this.gbExtras.Controls.Add(this.cbPepers);
            this.gbExtras.Controls.Add(this.tbKetchap);
            this.gbExtras.Controls.Add(this.tbExtraCheese);
            this.gbExtras.Controls.Add(this.tbPepers);
            this.gbExtras.Location = new System.Drawing.Point(270, 12);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(208, 135);
            this.gbExtras.TabIndex = 5;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras";
            // 
            // cbKetchap
            // 
            this.cbKetchap.AutoSize = true;
            this.cbKetchap.Location = new System.Drawing.Point(6, 97);
            this.cbKetchap.Name = "cbKetchap";
            this.cbKetchap.Size = new System.Drawing.Size(78, 20);
            this.cbKetchap.TabIndex = 7;
            this.cbKetchap.Text = "Ketchap";
            this.cbKetchap.UseVisualStyleBackColor = true;
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(6, 58);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(107, 20);
            this.cbExtraCheese.TabIndex = 6;
            this.cbExtraCheese.Text = "Extra cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // cbPepers
            // 
            this.cbPepers.AutoSize = true;
            this.cbPepers.Location = new System.Drawing.Point(6, 23);
            this.cbPepers.Name = "cbPepers";
            this.cbPepers.Size = new System.Drawing.Size(73, 20);
            this.cbPepers.TabIndex = 5;
            this.cbPepers.Text = "Pepers";
            this.cbPepers.UseVisualStyleBackColor = true;
            // 
            // tbKetchap
            // 
            this.tbKetchap.Location = new System.Drawing.Point(129, 95);
            this.tbKetchap.Name = "tbKetchap";
            this.tbKetchap.Size = new System.Drawing.Size(65, 22);
            this.tbKetchap.TabIndex = 4;
            // 
            // tbExtraCheese
            // 
            this.tbExtraCheese.Location = new System.Drawing.Point(129, 56);
            this.tbExtraCheese.Name = "tbExtraCheese";
            this.tbExtraCheese.Size = new System.Drawing.Size(65, 22);
            this.tbExtraCheese.TabIndex = 3;
            // 
            // tbPepers
            // 
            this.tbPepers.Location = new System.Drawing.Point(129, 21);
            this.tbPepers.Name = "tbPepers";
            this.tbPepers.Size = new System.Drawing.Size(65, 22);
            this.tbPepers.TabIndex = 1;
            // 
            // gbDrink
            // 
            this.gbDrink.Controls.Add(this.lblTotal);
            this.gbDrink.Controls.Add(this.tbBeerTotal);
            this.gbDrink.Controls.Add(this.tbJuiceTotal);
            this.gbDrink.Controls.Add(this.tbFuzzyTotal);
            this.gbDrink.Controls.Add(this.lblPrice);
            this.gbDrink.Controls.Add(this.tbBeerPrice);
            this.gbDrink.Controls.Add(this.tbJuicePrice);
            this.gbDrink.Controls.Add(this.tbFuzzyPrice);
            this.gbDrink.Controls.Add(this.lblQuantity);
            this.gbDrink.Controls.Add(this.lblBeer);
            this.gbDrink.Controls.Add(this.lblJuice);
            this.gbDrink.Controls.Add(this.lblFuzzyDrink);
            this.gbDrink.Controls.Add(this.tbBeerQuantity);
            this.gbDrink.Controls.Add(this.tbJuiceQuantity);
            this.gbDrink.Controls.Add(this.tbFuzzyQuantity);
            this.gbDrink.Location = new System.Drawing.Point(15, 162);
            this.gbDrink.Name = "gbDrink";
            this.gbDrink.Size = new System.Drawing.Size(477, 152);
            this.gbDrink.TabIndex = 5;
            this.gbDrink.TabStop = false;
            this.gbDrink.Text = "Drink";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(406, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // tbBeerTotal
            // 
            this.tbBeerTotal.Enabled = false;
            this.tbBeerTotal.Location = new System.Drawing.Point(398, 119);
            this.tbBeerTotal.Name = "tbBeerTotal";
            this.tbBeerTotal.ReadOnly = true;
            this.tbBeerTotal.Size = new System.Drawing.Size(65, 22);
            this.tbBeerTotal.TabIndex = 15;
            // 
            // tbJuiceTotal
            // 
            this.tbJuiceTotal.Enabled = false;
            this.tbJuiceTotal.Location = new System.Drawing.Point(398, 80);
            this.tbJuiceTotal.Name = "tbJuiceTotal";
            this.tbJuiceTotal.ReadOnly = true;
            this.tbJuiceTotal.Size = new System.Drawing.Size(65, 22);
            this.tbJuiceTotal.TabIndex = 14;
            // 
            // tbFuzzyTotal
            // 
            this.tbFuzzyTotal.Enabled = false;
            this.tbFuzzyTotal.Location = new System.Drawing.Point(398, 45);
            this.tbFuzzyTotal.Name = "tbFuzzyTotal";
            this.tbFuzzyTotal.ReadOnly = true;
            this.tbFuzzyTotal.Size = new System.Drawing.Size(65, 22);
            this.tbFuzzyTotal.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(288, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // tbBeerPrice
            // 
            this.tbBeerPrice.Location = new System.Drawing.Point(280, 119);
            this.tbBeerPrice.Name = "tbBeerPrice";
            this.tbBeerPrice.Size = new System.Drawing.Size(65, 22);
            this.tbBeerPrice.TabIndex = 11;
            // 
            // tbJuicePrice
            // 
            this.tbJuicePrice.Location = new System.Drawing.Point(280, 80);
            this.tbJuicePrice.Name = "tbJuicePrice";
            this.tbJuicePrice.Size = new System.Drawing.Size(65, 22);
            this.tbJuicePrice.TabIndex = 10;
            // 
            // tbFuzzyPrice
            // 
            this.tbFuzzyPrice.Location = new System.Drawing.Point(280, 45);
            this.tbFuzzyPrice.Name = "tbFuzzyPrice";
            this.tbFuzzyPrice.Size = new System.Drawing.Size(65, 22);
            this.tbFuzzyPrice.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(200, 18);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblBeer
            // 
            this.lblBeer.AutoSize = true;
            this.lblBeer.Location = new System.Drawing.Point(6, 119);
            this.lblBeer.Name = "lblBeer";
            this.lblBeer.Size = new System.Drawing.Size(36, 16);
            this.lblBeer.TabIndex = 7;
            this.lblBeer.Text = "Beer";
            // 
            // lblJuice
            // 
            this.lblJuice.AutoSize = true;
            this.lblJuice.Location = new System.Drawing.Point(6, 86);
            this.lblJuice.Name = "lblJuice";
            this.lblJuice.Size = new System.Drawing.Size(129, 16);
            this.lblJuice.TabIndex = 6;
            this.lblJuice.Text = "Apple / Orange juice";
            // 
            // lblFuzzyDrink
            // 
            this.lblFuzzyDrink.AutoSize = true;
            this.lblFuzzyDrink.Location = new System.Drawing.Point(6, 48);
            this.lblFuzzyDrink.Name = "lblFuzzyDrink";
            this.lblFuzzyDrink.Size = new System.Drawing.Size(160, 16);
            this.lblFuzzyDrink.TabIndex = 5;
            this.lblFuzzyDrink.Text = "Coca-Cola / Fanta / Sprite";
            // 
            // tbBeerQuantity
            // 
            this.tbBeerQuantity.Location = new System.Drawing.Point(190, 122);
            this.tbBeerQuantity.Name = "tbBeerQuantity";
            this.tbBeerQuantity.Size = new System.Drawing.Size(65, 22);
            this.tbBeerQuantity.TabIndex = 4;
            // 
            // tbJuiceQuantity
            // 
            this.tbJuiceQuantity.Location = new System.Drawing.Point(190, 83);
            this.tbJuiceQuantity.Name = "tbJuiceQuantity";
            this.tbJuiceQuantity.Size = new System.Drawing.Size(65, 22);
            this.tbJuiceQuantity.TabIndex = 3;
            // 
            // tbFuzzyQuantity
            // 
            this.tbFuzzyQuantity.Location = new System.Drawing.Point(190, 48);
            this.tbFuzzyQuantity.Name = "tbFuzzyQuantity";
            this.tbFuzzyQuantity.Size = new System.Drawing.Size(65, 22);
            this.tbFuzzyQuantity.TabIndex = 1;
            // 
            // gbDessert
            // 
            this.gbDessert.Controls.Add(this.lblDessertPrice);
            this.gbDessert.Controls.Add(this.lbDessert);
            this.gbDessert.Controls.Add(this.btnOrder);
            this.gbDessert.Controls.Add(this.btnCancel);
            this.gbDessert.Controls.Add(this.tbDessertPrice);
            this.gbDessert.Location = new System.Drawing.Point(20, 332);
            this.gbDessert.Name = "gbDessert";
            this.gbDessert.Size = new System.Drawing.Size(256, 198);
            this.gbDessert.TabIndex = 6;
            this.gbDessert.TabStop = false;
            this.gbDessert.Text = "Dessert";
            // 
            // lbDessert
            // 
            this.lbDessert.FormattingEnabled = true;
            this.lbDessert.ItemHeight = 16;
            this.lbDessert.Items.AddRange(new object[] {
            "Fruit pie",
            "Ice cream",
            "Cake"});
            this.lbDessert.Location = new System.Drawing.Point(6, 30);
            this.lbDessert.Name = "lbDessert";
            this.lbDessert.Size = new System.Drawing.Size(120, 148);
            this.lbDessert.TabIndex = 0;
            // 
            // tbDessertPrice
            // 
            this.tbDessertPrice.Location = new System.Drawing.Point(157, 49);
            this.tbDessertPrice.Name = "tbDessertPrice";
            this.tbDessertPrice.Size = new System.Drawing.Size(73, 22);
            this.tbDessertPrice.TabIndex = 2;
            // 
            // lblDessertPrice
            // 
            this.lblDessertPrice.AutoSize = true;
            this.lblDessertPrice.Location = new System.Drawing.Point(145, 30);
            this.lblDessertPrice.Name = "lblDessertPrice";
            this.lblDessertPrice.Size = new System.Drawing.Size(87, 16);
            this.lblDessertPrice.TabIndex = 1;
            this.lblDessertPrice.Text = "Dessert price";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(142, 96);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(108, 31);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.tbChange);
            this.gbPayment.Controls.Add(this.tbPayed);
            this.gbPayment.Controls.Add(this.lblChange);
            this.gbPayment.Controls.Add(this.lblPayed);
            this.gbPayment.Controls.Add(this.tbTotal);
            this.gbPayment.Controls.Add(this.lblTotalP);
            this.gbPayment.Location = new System.Drawing.Point(292, 332);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(200, 198);
            this.gbPayment.TabIndex = 7;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment";
            // 
            // lblTotalP
            // 
            this.lblTotalP.AutoSize = true;
            this.lblTotalP.Location = new System.Drawing.Point(11, 39);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(103, 16);
            this.lblTotalP.TabIndex = 0;
            this.lblTotalP.Text = "Total for paying:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(120, 39);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(66, 22);
            this.tbTotal.TabIndex = 1;
            // 
            // lblPayed
            // 
            this.lblPayed.AutoSize = true;
            this.lblPayed.Location = new System.Drawing.Point(11, 96);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(50, 16);
            this.lblPayed.TabIndex = 2;
            this.lblPayed.Text = "Payed:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(6, 154);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(57, 16);
            this.lblChange.TabIndex = 3;
            this.lblChange.Text = "Change:";
            // 
            // tbPayed
            // 
            this.tbPayed.Location = new System.Drawing.Point(86, 93);
            this.tbPayed.Name = "tbPayed";
            this.tbPayed.Size = new System.Drawing.Size(100, 22);
            this.tbPayed.TabIndex = 4;
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(86, 151);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(100, 22);
            this.tbChange.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 553);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.gbDessert);
            this.Controls.Add(this.gbDrink);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            this.gbDrink.ResumeLayout(false);
            this.gbDrink.PerformLayout();
            this.gbDessert.ResumeLayout(false);
            this.gbDessert.PerformLayout();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.TextBox tbSizeBig;
        private System.Windows.Forms.TextBox tbSizeMid;
        private System.Windows.Forms.TextBox tbSizeSmall;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.CheckBox cbKetchap;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.CheckBox cbPepers;
        private System.Windows.Forms.TextBox tbKetchap;
        private System.Windows.Forms.TextBox tbExtraCheese;
        private System.Windows.Forms.TextBox tbPepers;
        private System.Windows.Forms.GroupBox gbDrink;
        private System.Windows.Forms.Label lblFuzzyDrink;
        private System.Windows.Forms.TextBox tbBeerQuantity;
        private System.Windows.Forms.TextBox tbJuiceQuantity;
        private System.Windows.Forms.TextBox tbFuzzyQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbBeerTotal;
        private System.Windows.Forms.TextBox tbJuiceTotal;
        private System.Windows.Forms.TextBox tbFuzzyTotal;
        private System.Windows.Forms.TextBox tbBeerPrice;
        private System.Windows.Forms.TextBox tbJuicePrice;
        private System.Windows.Forms.TextBox tbFuzzyPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBeer;
        private System.Windows.Forms.Label lblJuice;
        private System.Windows.Forms.GroupBox gbDessert;
        private System.Windows.Forms.ListBox lbDessert;
        private System.Windows.Forms.TextBox tbDessertPrice;
        private System.Windows.Forms.Label lblDessertPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.TextBox tbPayed;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPayed;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.Label lblPrice;
    }
}

