using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPaud6
{
    public partial class Form1 : Form
    {
        public RandomPicker randomPicker {  get; set; }
        public HangmanWord hangmanWord { get; set; }
        int timeLeft;
            
        public Form1()
        {
            InitializeComponent();
            randomPicker = new RandomPicker();
            init(); 
        }
        private void init()
        {
            hangmanWord = new HangmanWord(randomPicker.pick());
            tbTimer.Text = "02:00";
            updateTextBoxes();
            pbWrongTries.Maximum = HangmanWord.MAX_RETRIES;
            pbWrongTries.Value = 0;
            timeLeft = 120;
            timer1.Start();
            pbTimer.Maximum = 120;
            pbTimer.Value = 120;
            tbLetter.Text = "";
        }
        private void updateTextBoxes()
        {
            tbWordState.Text = hangmanWord.GetMaskedWord();
            tbGuessedLetters.Text = hangmanWord.getMaskedGuessedLetters();

        }
        private void ShowMessage(string description)
        {
            DialogResult dr = MessageBox.Show(description, "Game Over", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //nova igra
                 init();
            }
            else
            {
                this.Close();
            }
        }
        private void btnTryLetter_Click(object sender, EventArgs e)
        {
              if(!string.IsNullOrEmpty(tbLetter.Text))
            {
                char letter = tbLetter.Text[0];
                hangmanWord.GuessLetter(letter);
                updateTextBoxes();
                pbWrongTries.Value = hangmanWord.WrongCount;
                if (hangmanWord.Win())
                {
                    timer1.Stop();
                    ShowMessage("Congrats, you won! Do you want a new game?");
                }
                else if(hangmanWord.Lose())
                {
                    timer1.Stop();
                    ShowMessage("Sorry, you lost! Do you want a new game?");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            tbTimer.Text = String.Format("{0}:{1}", timeLeft / 60, timeLeft % 60);
            pbTimer.Value = timeLeft;   
            if(timeLeft <= 0)
            {
                //timer1.Stop();
                ShowMessage("Sorry, time over ! Do you want a new game?");
            }
        }
    }
}
