using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool spieler = false;
        private int xWins = 0;
        private int oWins = 0;
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"X: {xWins}";
            label2.Text = $"O: {oWins}";
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;



            if (spieler == false)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            button.Enabled = false;

            CheckWin();

            spieler = !spieler;
        }

        public void CheckWin()
        {
            string winner;
            
            if (spieler == false)
            {
                winner = "X";
            }
            else
            {
                winner = "O";
            }
            
            if (button1.Enabled == false && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
            else if (button4.Enabled == false && button4.Text == button5.Text && button4.Text == button6.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
            else if (button7.Enabled == false && button7.Text == button8.Text && button7.Text == button9.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
            else if (button1.Enabled == false && button1.Text == button4.Text && button1.Text == button7.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
            else if (button2.Enabled == false && button2.Text == button5.Text && button2.Text == button8.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
            else if (button3.Enabled == false && button3.Text == button6.Text && button9.Text == button3.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
            else if (button1.Enabled == false && button1.Text == button5.Text && button1.Text == button9.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
            else if (button3.Enabled == false && button7.Text == button5.Text && button7.Text == button3.Text)
            {
                MessageBox.Show($"{winner} wins");
                UpdateWins(winner);
            }
        }

        public void UpdateWins(string winner)
        {
            if (winner == "X")
            {
                xWins++;
            }
            else if (winner == "O")
            {
                oWins++;
            }
            
            label1.Text = $"X: {xWins}";
            label2.Text = $"O: {oWins}";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            
            foreach (Control control in Controls)
            {
                if(control is Button)
                {
                    Button button = (Button)control;
                    if (button.Text != "reset")
                    {
                    button.Text = "";
                    button.Enabled = true;
                    }
                }
            }
        }


    }
}