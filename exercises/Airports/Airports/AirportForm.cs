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
    public partial class AirportForm : Form
    {
        public Airport CreatedAirport { get; set; }
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public AirportForm()
        {
            InitializeComponent();
        }

        private void btnOkA_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                CreatedAirport = new Airport(tbCity.Text, tbNameAirport.Text, tbShort.Text);
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelA_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text == "")
            {
                errorProvider1.SetError(tbCity, "You must enter a city");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
            }
        }

        private void tbNameAirport_Validating(object sender, CancelEventArgs e)
        {
            if (tbNameAirport.Text == "")
            {
                errorProvider1.SetError(tbNameAirport, "You must enter a name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbNameAirport, null);
            }
        }

        private void tbShort_Validating(object sender, CancelEventArgs e)
        {
            if (tbShort.Text.Length != 3)
            {
                errorProvider1.SetError(tbShort, "The code must be 3 characters");
                e.Cancel = true;
            }
            else
            {
                bool flag = true;
                foreach (Char c in tbShort.Text)
                {
                    if (Char.IsLower(c) || !Char.IsLetter(c))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    errorProvider1.SetError(tbShort, null);
                }
                else
                {
                    errorProvider1.SetError(tbShort, "All characters must be uppercase letters");
                    e.Cancel = true;
                }
            }
        }
    }
}
