using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buses
{
    public partial class BusForm : Form
    {
        public Bus createdBus { get; set; } = new Bus();
        public ErrorProvider errorProvider1 { get; set; } = new ErrorProvider();
        public BusForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                createdBus = new Bus(tbRegistration.Text, tbName.Text, cbLocal.Checked);
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
                errorProvider1.SetError(tbName, "You must enter a bus name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }
        private bool checkReg()
        {
            int count = 0;
            foreach (Char c in tbRegistration.Text)
            {
                if (Char.IsLetter(c))
                {
                    return false;
                }
                count++;
            }
            if (count == 4)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void tbRegistration_Validating(object sender, CancelEventArgs e)
        {
            if (!checkReg())
            {
                errorProvider1.SetError(tbRegistration, "You must enter a bus name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbRegistration, null);
            }
        }
    }
}
