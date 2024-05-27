using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class ProductForm : Form
    {
        public Product createdProduct { get; set; }
        //public float Price { get; set; }
        public ErrorProvider errorProvider1 { get; set; } = new ErrorProvider();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
                createdProduct = new Product(tbName.Text, tbCategory.Text, tbPrice.Text);
                DialogResult = DialogResult.OK;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "You must enter a name of the product");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (tbCategory.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCategory, "You must enter the category of the product");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCategory, null);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrice.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPrice, "You must enter the price of the product");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPrice, null);
            }
        }
    }
}
