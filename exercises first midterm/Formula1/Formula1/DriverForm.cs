using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1
{
    public partial class DriverForm : Form
    {
        public Driver createdDriver { get; set; }
        public ErrorProvider errorProvider1 { get; set; } = new ErrorProvider();
        public DriverForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                createdDriver = new Driver(tbName.Text, Convert.ToInt32(nudAge.Value), cbFirstDriver.Checked);
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                
                errorProvider1.SetError(tbName, "You must enter a name");
                e.Cancel = true;
            }
            else
            {
                
                errorProvider1.SetError(tbName, null);
                
            }
        }
    }
}
