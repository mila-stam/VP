using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class DestinationForm : Form
    {
        public Destination createdDestination { get; set; }
        public ErrorProvider errorProvider2 { get; set; } = new ErrorProvider();
        public DestinationForm()
        {
            InitializeComponent();
        }

        private void btnOkD_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                createdDestination = new Destination(tbNameDest.Text, nudDistance.Value, nudPrice.Value);
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelD_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbNameDest_Validating(object sender, CancelEventArgs e)
        {
            if (tbNameDest.Text == "")
            {
                errorProvider2.SetError(tbNameDest, "You must enter a name");
                e.Cancel = true;

            }
            else
            {
                errorProvider2.SetError(tbNameDest, null);
            }
        }
    }
}
