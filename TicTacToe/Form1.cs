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
        int player = 0;
        bool winner = false;
        bool gameFinish = true;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedLabel = sender as Button;

            if (winner)
            {
                return;
            }

            if (clickedLabel.Text == "")
            {
                if (player == 0)
                {
                    clickedLabel.Text = "X";
                    labelPlayer.Text = "Player 2's Turn";
                    checkWin();

                    player = 1;
                }
                else
                {
                    clickedLabel.Text = "O";
                    labelPlayer.Text = "Player 1's Turn";
                    checkWin();

                    player = 0;
                }
            }
        }

        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                winner = true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                winner = true;

            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                winner = true;

            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                winner = true;

            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                winner = true;

            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                winner = true;

            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                winner = true;

            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                winner = true;

            }


            if (winner)
            {
                if (player == 0)
                {
                    MessageBox.Show("Congrats Player 1!", "Win");
                    labelWinner.Text = "Player 1";
                }
                else
                {
                    MessageBox.Show("Congrats Player 2!", "Win");
                    labelWinner.Text = "Player 2";
                }
            }

            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Button button = control as Button;

                if(button.Text == "")
                {
                    gameFinish = false;
                }

                
            }

            if (gameFinish)
            {
                MessageBox.Show("Draw Game!", "Draw");
                labelWinner.Text = "N/A";
            }

            gameFinish = true;
        }
    }
}
