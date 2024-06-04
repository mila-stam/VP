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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAirport_Click(object sender, EventArgs e)
        {
            AirportForm airportForm = new AirportForm();
            if (airportForm.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(airportForm.createdAirport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbAirports.Items.Remove(lbAirports.SelectedItem);
                }
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if(lbAirports.Items.Count > 0)
            {
                if(lbAirports.SelectedIndex != -1)
                {
                    DestinationForm desstinationForm = new DestinationForm();
                    Airport selectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                    if(desstinationForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedAirport.destinations.Add(desstinationForm.createdDestination);
                        loadItems();
                    }
                }
            }
        }

        public void loadItems()
        {
            lbDestinations.Items.Clear();
            tbMostExpensive.Clear();
            tbAverage.Clear();
            if(lbAirports.Items.Count > 0)
            {
                if(lbAirports.SelectedIndex != -1)
                {
                    Airport selectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                    foreach(Destination d in selectedAirport.destinations)
                    {
                        lbDestinations.Items.Add(d);
                    } 


                    //most expensive
                    if(lbDestinations.Items.Count > 0)
                    {
                        Destination max = lbDestinations.Items[0] as Destination;
                        foreach(Destination d in selectedAirport.destinations)
                        {
                            if(d.Price  > max.Price)
                            {
                                max = d;
                            }
                        }
                        tbMostExpensive.Text = max.ToString();
                    }

                    //avg
                    float avg = 0;
                    foreach(Destination d in selectedAirport.destinations)
                    {
                        avg += d.Price;
                    }
                    avg = avg/lbDestinations.Items.Count;
                    tbAverage.Text = avg.ToString();
                }
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex != -1 ) {
                loadItems();
            }
        }
    }
}
