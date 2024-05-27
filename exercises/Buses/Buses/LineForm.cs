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
    public partial class LineForm : Form
    {
        public Line createdLine {  get; set; }
        public ErrorProvider errorProvider1 { get; set; } = new ErrorProvider();

        public LineForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                createdLine = new Line(tbDestination.Text, (int)nudHour.Value, (int)nudMinutes.Value, (int)nudPrice.Value);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestination.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDestination, "Enter a destination");
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
            }
        }
    }
}
