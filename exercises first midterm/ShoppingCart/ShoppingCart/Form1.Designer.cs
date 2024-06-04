namespace ShoppingCart
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
            this.lblProductList = new System.Windows.Forms.Label();
            this.lbProductList = new System.Windows.Forms.ListBox();
            this.btnEmptyProductList = new System.Windows.Forms.Button();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmptyTheCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnDeleteFromCart = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Location = new System.Drawing.Point(12, 25);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(72, 16);
            this.lblProductList.TabIndex = 0;
            this.lblProductList.Text = "Product list";
            // 
            // lbProductList
            // 
            this.lbProductList.FormattingEnabled = true;
            this.lbProductList.ItemHeight = 16;
            this.lbProductList.Location = new System.Drawing.Point(12, 44);
            this.lbProductList.Name = "lbProductList";
            this.lbProductList.Size = new System.Drawing.Size(266, 340);
            this.lbProductList.TabIndex = 1;
            this.lbProductList.SelectedIndexChanged += new System.EventHandler(this.lbProductList_SelectedIndexChanged);
            // 
            // btnEmptyProductList
            // 
            this.btnEmptyProductList.Location = new System.Drawing.Point(12, 404);
            this.btnEmptyProductList.Name = "btnEmptyProductList";
            this.btnEmptyProductList.Size = new System.Drawing.Size(266, 34);
            this.btnEmptyProductList.TabIndex = 2;
            this.btnEmptyProductList.Text = "Empty the list with products";
            this.btnEmptyProductList.UseVisualStyleBackColor = true;
            this.btnEmptyProductList.Click += new System.EventHandler(this.btnEmptyProductList_Click);
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 16;
            this.lbCart.Location = new System.Drawing.Point(522, 44);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(266, 308);
            this.lbCart.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cart";
            // 
            // btnEmptyTheCart
            // 
            this.btnEmptyTheCart.Location = new System.Drawing.Point(522, 404);
            this.btnEmptyTheCart.Name = "btnEmptyTheCart";
            this.btnEmptyTheCart.Size = new System.Drawing.Size(266, 34);
            this.btnEmptyTheCart.TabIndex = 5;
            this.btnEmptyTheCart.Text = "Empty the cart";
            this.btnEmptyTheCart.UseVisualStyleBackColor = true;
            this.btnEmptyTheCart.Click += new System.EventHandler(this.btnEmptyTheCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(296, 230);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(208, 34);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to cart >>";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnDeleteFromCart
            // 
            this.btnDeleteFromCart.Location = new System.Drawing.Point(296, 270);
            this.btnDeleteFromCart.Name = "btnDeleteFromCart";
            this.btnDeleteFromCart.Size = new System.Drawing.Size(208, 34);
            this.btnDeleteFromCart.TabIndex = 7;
            this.btnDeleteFromCart.Text = "Delete from the cart";
            this.btnDeleteFromCart.UseVisualStyleBackColor = true;
            this.btnDeleteFromCart.Click += new System.EventHandler(this.btnDeleteFromCart_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(296, 310);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(208, 34);
            this.btnAddNewProduct.TabIndex = 8;
            this.btnAddNewProduct.Text = "Add new product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(296, 350);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(208, 34);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Delete product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tbPrice);
            this.gbDetails.Controls.Add(this.tbCategory);
            this.gbDetails.Controls.Add(this.tbName);
            this.gbDetails.Controls.Add(this.lblPrice);
            this.gbDetails.Controls.Add(this.lblCategory);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Location = new System.Drawing.Point(296, 44);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(208, 180);
            this.gbDetails.TabIndex = 10;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details for the products";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 77);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 52);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(196, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(597, 362);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(191, 22);
            this.tbTotal.TabIndex = 4;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(6, 96);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(196, 22);
            this.tbCategory.TabIndex = 5;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(9, 152);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.btnDeleteFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnEmptyTheCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.btnEmptyProductList);
            this.Controls.Add(this.lbProductList);
            this.Controls.Add(this.lblProductList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.ListBox lbProductList;
        private System.Windows.Forms.Button btnEmptyProductList;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmptyTheCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnDeleteFromCart;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label6;
    }
}

