using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            if(productForm.ShowDialog() == DialogResult.OK )
            {
                lbProductList.Items.Add(productForm.createdProduct);
            }
            lbProductList.ClearSelected();
            tbName.Clear();
            tbCategory.Clear();
            tbPrice.Clear();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(lbProductList.SelectedIndex != -1)
            {
                lbProductList.Items.Remove(lbProductList.SelectedItem);
            }
        }

        private void lbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbProductList.SelectedIndex != -1)
            {
                Product selectedProduct = lbProductList.SelectedItem as Product;
                tbName.Text = selectedProduct.Name.ToString();
                tbPrice.Text = selectedProduct.Price.ToString(); 
                tbCategory.Text = selectedProduct.Category.ToString();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(lbProductList.SelectedIndex != -1)
            {
                Product selectedProduct = lbProductList.SelectedItem as Product;
                lbCart.Items.Add(selectedProduct);
                tbTotal.Text = calculatePrice().ToString();
            }
        }


        private int calculatePrice()
        {
            int price = 0;
            foreach(Product product in lbCart.Items)
            {
                price += product.Price;
            }
            return price;
        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            if(lbCart.SelectedIndex != -1)
            {
                lbCart.Items.Remove(lbCart.SelectedItem);
            }
        }

        private void btnEmptyProductList_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lbProductList.Items.Clear();
                tbName.Clear();
                tbCategory.Clear();
                tbPrice.Clear();

            }
            
        }

        private void btnEmptyTheCart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lbCart.Items.Clear();
                tbTotal.Clear();
            }
        }
    }
}
