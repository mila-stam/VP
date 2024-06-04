using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport2
{
    public partial class DestinationForm : Form
    {
        public Destination createdDestination {  get; set; }
        public ErrorProvider errorProvider { get; set; } = new ErrorProvider();
        public DestinationForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                createdDestination = new Destination(tbNameD.Text, (int)nudDistance.Value, (int)nudPrice.Value);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbNameD_Validating(object sender, CancelEventArgs e)
        {
            if(tbNameD.Text == "")
            {
                errorProvider.SetError(tbNameD, "enter a name");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbNameD, null);
                
            }
        }
    }
}
