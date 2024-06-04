using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsBet
{
    public partial class Form1 : Form
    {
        public decimal TotalCoef { get; set; } = 1;
        public decimal TotalGain { get; set; } = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            Form2 teamForm = new Form2();
            DialogResult result = teamForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbTeams.Items.Add(teamForm.CreatedTeam);
            }
        }

        private void btnAddToBilten_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItems.Count == 2)
            {
                Team team1 = lbTeams.SelectedItems[0] as Team;
                Team team2 = lbTeams.SelectedItems[1] as Team;
                if (!team1.Country.Equals(team2.Country))
                {
                    MessageBox.Show("Izbranite timovi mora da bidat od ista drzhava");
                }
                else
                {
                    Game game = new Game(tbCode.Text, team1, team2, updown1.Value, updownX.Value, updown2.Value);
                    lbBilten.Items.Add(game);
                    lbTeams.ClearSelected();
                    updown1.Value = 1.0M;
                    updownX.Value = 1.0M;
                    updown2.Value = 1.0M;

                    tbCode.Clear();
                }
            }
            else
            {
                MessageBox.Show("Mora da bidat selektirani 2 tima");
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (lbBilten.SelectedIndex != -1 && ddType.SelectedIndex != -1)
            {
                Game game = lbBilten.SelectedItem as Game;
                int type = ddType.Text == "1" ? 0 : (ddType.Text == "X" ? 1 : 2);
                Ticket ticket = new Ticket(game, type);
                lbTicket.Items.Add(ticket);
                lbBilten.ClearSelected();
                tbCode1.Clear();
                updateMoneyData();
            }
        }

        private void tbCode1_TextChanged(object sender, EventArgs e)
        {
            lbBilten.SelectedItems.Clear();
            String codeSearch = tbCode1.Text;
            for (int i = 0; i < lbBilten.Items.Count; i++)
            {
                Game game = lbBilten.Items[i] as Game;
                if (game.Code == codeSearch)
                {
                    lbBilten.SelectedIndex = i;
                    break;
                }
            }
        }
        private decimal recalculate()
        {
            decimal product = 1;
            for (int i = 0; i < lbTicket.Items.Count; i++)
            {
                Ticket ticket = lbTicket.Items[i] as Ticket;
                int type = ticket.Type;
                Game game = ticket.game;
                product *= (type == 0 ? game.coef1 : type == 1 ? game.coefX : game.coef2);
            }
            return product;
        }

        private void updateMoneyData()
        {
            TotalCoef = recalculate();
            TotalGain = recalculate() * updownPay.Value;
            tbTotalCoef.Text = TotalCoef.ToString();
            tbTotalGain.Text = TotalGain.ToString();
        }
        private void lbTicket_SizeChanged(object sender, EventArgs e)
        {
            TotalCoef = recalculate();
            TotalGain = recalculate() * updownPay.Value;
            tbTotalCoef.Text = TotalCoef.ToString();
            tbTotalGain.Text = TotalGain.ToString();
        }

        private void updownPay_ValueChanged(object sender, EventArgs e)
        {
            updateMoneyData();

        }
    }
}
