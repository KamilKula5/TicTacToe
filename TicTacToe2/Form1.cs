using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class Form1 : Form
    {
        public bool player1Plays = true;
        public int counter = 0; //zmienna służąca do sprawdzenia remisu
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button1.Enabled = false;
                button1.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button1.Enabled = false;
                button1.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button2.Enabled = false;
                button2.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button2.Enabled = false;
                button2.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button3.Enabled = false;
                button3.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button3.Enabled = false;
                button3.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button4.Enabled = false;
                button4.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button4.Enabled = false;
                button4.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button5.Enabled = false;
                button5.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button5.Enabled = false;
                button5.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button6.Enabled = false;
                button6.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button6.Enabled = false;
                button6.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button7.Enabled = false;
                button7.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button7.Enabled = false;
                button7.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button8.Enabled = false;
                button8.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button8.Enabled = false;
                button8.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player1Plays)
            {
                button9.Enabled = false;
                button9.Text = "X";
                player1Plays = false;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 2";
                WhoWins();
            }
            else
            {
                button9.Enabled = false;
                button9.Text = "O";
                player1Plays = true;
                counter++;
                label1.Text = "TERAZ GRA GRACZ 1";
                WhoWins();
            }
        }
        public void WhoWins()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Gracz 1 wygrywa!");
                Reset();
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Gracz 2 wygrywa!");
                Reset();
            }
            if (counter == 9)
            {
                MessageBox.Show("Remis");
                Reset();
            }
        }
        public void Reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            counter = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        
    }
    
}
