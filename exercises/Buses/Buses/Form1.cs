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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            BusForm busForm = new BusForm();
            if (busForm.ShowDialog() == DialogResult.OK)
            {
                lbBuses.Items.Add(busForm.createdBus);
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (lbBuses.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbBuses.Items.Remove(lbBuses.SelectedItem);
                }
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (lbBuses.Items.Count > 0)
            {
                if (lbBuses.SelectedIndex != -1)
                {
                    LineForm lineForm = new LineForm();

                    if (lineForm.ShowDialog() == DialogResult.OK)
                    {
                        Bus bus = lbBuses.Items[lbBuses.SelectedIndex] as Bus;
                        bus.lines.Add(lineForm.createdLine);

                    }
                    loadItems();
                }
            }


        }

        public void loadItems()
        {
            lbLines.Items.Clear();
            tbAverage.Clear();
            tbMostExpensive.Clear();
            if (lbBuses.SelectedIndex != -1)
            {
                Bus bus = lbBuses.Items[lbBuses.SelectedIndex] as Bus;
                foreach (Line line in bus.lines)
                {
                    lbLines.Items.Add(line);
                }

                //avg
                float avg = 0;
                foreach (Line line in bus.lines)
                {
                    avg += line.Price;
                }
                avg = avg / bus.lines.Count;
                tbAverage.Text = avg.ToString();


                //max
                if (lbLines.Items.Count > 0)
                {
                    Line max = lbLines.Items[0] as Line;

                    foreach (Line line in bus.lines)
                    {
                        if (max.Price < line.Price)
                        {
                            max = line;
                        }
                    }
                    tbMostExpensive.Text = max.ToString();
                }
            }
        }


        private void lbBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBuses.SelectedIndex != -1)
            {
                loadItems();
            }
        }
    }
}
