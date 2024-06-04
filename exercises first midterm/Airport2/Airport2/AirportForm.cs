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
    public partial class AirportForm : Form
    {
        public Airport createdAirport { get; set; }
        public ErrorProvider errorProvider1 { get; set; } = new ErrorProvider();
        public AirportForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                createdAirport = new Airport(tbCity.Text, tbNameA.Text, tbCode.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text == "")
            {
                errorProvider1.SetError(tbCity, "enter city");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
            }
        }

        private void tbNameA_Validating(object sender, CancelEventArgs e)
        {
            if (tbNameA.Text == "")
            {
                errorProvider1.SetError(tbNameA, "enter name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbNameA, null);
            }
        }
        private bool checkCode()
        {
            int count = 0;
            foreach (Char c in tbCode.Text)
            {
                if (Char.IsDigit(c) || Char.IsLower(c))
                {
                    return false;
                }
                count++;
            }
            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if(!checkCode())
            {
                errorProvider1.SetError(tbCode, "enter valid code");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCode, null);
            }
        }
    }
}
