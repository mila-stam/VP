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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm();
            if (driverForm.ShowDialog() == DialogResult.OK)
            {
                lbDrivers.Items.Add(driverForm.createdDriver);
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                lbDrivers.Items.RemoveAt(lbDrivers.SelectedIndex);
            }
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            if (lbDrivers.Items.Count > 0)
            {
                if (lbDrivers.SelectedIndex != -1)
                {
                    Driver driver = lbDrivers.Items[lbDrivers.SelectedIndex] as Driver;
                    driver.Laps.Add(new Lap((int)nudMinutes.Value, (int)nudSeconds.Value));
                    loadLaps();
                    nudMinutes.Value = 0;
                    nudSeconds.Value = 0;
                }
            }


        }
        public void loadLaps()
        {
            lbLaps.Items.Clear();
            if (lbDrivers.SelectedIndex != -1)
            {
                Driver driver = lbDrivers.Items[lbDrivers.SelectedIndex] as Driver;
                foreach (Lap l in driver.Laps)
                {
                    lbLaps.Items.Add(l);
                }
                if (lbLaps.Items.Count > 0)
                {
                    bestLap();
                }
            }
        }
        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (nudSeconds.Value > 59)
            {
                nudMinutes.Value++;
                nudSeconds.Value = 0;
            }
            if (nudSeconds.Value == -1)
            {
                nudMinutes.Value--;
                nudSeconds.Value = 59;
            }
        }



        private void bestLap()
        {
            Lap bestLap = lbLaps.Items[0] as Lap;
            foreach (Lap lap in lbLaps.Items)
            {
                if (lap.totalSec() < bestLap.totalSec())
                {
                    bestLap = lap;
                }
            }
            tbBestLap.Text = bestLap.ToString();
        }

        private void nudTime_ValueChanged(object sender, EventArgs e)
        {
            filterItems();
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                loadLaps();

            }
        }
        private void filterItems()
        {
            lbLaps.Items.Clear();
            if (lbDrivers.SelectedIndex != -1)
            {
                Driver driver = lbDrivers.Items[lbDrivers.SelectedIndex] as Driver;
                foreach (Lap l in driver.Laps)
                {
                    if (l.totalSec() > (int)nudTime.Value)
                    {
                        lbLaps.Items.Add(l);
                    }
                }

                if (lbLaps.Items.Count > 0)
                {
                    bestLap();
                }

            }
        }

    }
}
