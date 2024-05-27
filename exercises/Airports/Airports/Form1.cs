using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAddNewAirport_Click(object sender, EventArgs e)
        {
            AirportForm airportForm = new AirportForm();
            /*DialogResult result = airportForm.ShowDialog();*/
            if (airportForm.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(airportForm.CreatedAirport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dg = MessageBox.Show("Are you sure?", "Are you sure you're sure?", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                lbAirports.Items.RemoveAt(lbAirports.SelectedIndex);
            }

        }

        private void btnAddNewDestination_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                DestinationForm destinationForm = new DestinationForm();
                if (destinationForm.ShowDialog() == DialogResult.OK)
                {
                    Airport airport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                    airport.Destinations.Add(destinationForm.createdDestination);
                    loadDestinations();
                }
            }
        }


        private void loadDestinations()
        {
            lbDestinations.Items.Clear();
            tbAverage.Clear();
            tbMostExpensiveDestination.Clear();
            if (lbAirports.SelectedIndex != -1)
            {
                Airport airport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                foreach (Destination d in airport.Destinations)
                {
                    lbDestinations.Items.Add(d);
                }

                //avg
                int sum = 0;
                foreach (Destination d in airport.Destinations)
                {
                    sum += (int)d.Distance;
                }
                if (airport.Destinations.Count > 0)
                {
                    double avg = sum / airport.Destinations.Count;
                    tbAverage.Text = avg.ToString();
                }
                else
                {
                    tbAverage.Text = "this airport does not have destinations";
                }


                //max
                if(airport.Destinations.Count > 0)
                {
                    Destination maxD = airport.Destinations[0] as Destination;
                    foreach (Destination d in airport.Destinations)
                    {
                        if (d.Price > maxD.Price)
                        {
                            maxD = d;
                        }
                    }

                    tbMostExpensiveDestination.Text = maxD.ToString();
                }
                else
                {
                    tbMostExpensiveDestination.Text = "this airport does not have destinations";
                }

            }

        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }

        private void lbAirports_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }
    }
}
