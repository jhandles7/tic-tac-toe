using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        int player_turn = 0;
        bool winner = false;

        private void tile1_Click(object sender, EventArgs e)
        {
            if (tile1.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile1.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile1.Text = "O";
                    player_turn++;
                }
            }

            check_winner();
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            if (tile2.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile2.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile2.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            if (tile3.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile3.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile3.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            if (tile4.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile4.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile4.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            if (tile5.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile5.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile5.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            if (tile6.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile6.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile6.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            if (tile7.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile7.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile7.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            if (tile8.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile8.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile8.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            if (tile9.Text == "")
            {
                if (player_turn % 2 == 0)
                {
                    tile9.Text = "X";
                    player_turn++;
                }
                else
                {
                    tile9.Text = "O";
                    player_turn++;
                }
            }
            check_winner();
        }

        public void check_winner()
        {
            ///Check winner horizontally
            if (tile1.Text!= "" && tile2.Text != "" && tile3.Text != "")
            {
                if (tile1.Text == tile2.Text && tile1.Text == tile3.Text)
                {
                    if (tile1.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }
            if (tile4.Text != "" && tile5.Text != "" && tile6.Text != "")
            {
                if (tile4.Text == tile5.Text && tile4.Text == tile6.Text)
                {
                    if (tile4.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }
            if (tile7.Text != "" && tile8.Text != "" && tile9.Text != "")
            {
                if (tile7.Text == tile8.Text && tile7.Text == tile9.Text)
                {
                    if (tile7.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }

            ///Check winner vertically
            if (tile1.Text != "" && tile4.Text != "" && tile7.Text != "")
            {
                if (tile1.Text == tile4.Text && tile1.Text == tile7.Text)
                {
                    if (tile1.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }
            if (tile2.Text != "" && tile5.Text != "" && tile8.Text != "")
            {
                if (tile2.Text == tile5.Text && tile2.Text == tile8.Text)
                {
                    if (tile2.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }
            if (tile3.Text != "" && tile6.Text != "" && tile9.Text != "")
            {
                if (tile3.Text == tile6.Text && tile3.Text == tile9.Text)
                {
                    if (tile3.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }

            //Check winner diagonally
            if (tile1.Text != "" && tile5.Text != "" && tile9.Text != "")
            {
                if (tile1.Text == tile5.Text && tile1.Text == tile9.Text)
                {
                    if (tile1.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }
            if (tile3.Text != "" && tile5.Text != "" && tile7.Text != "")
            {
                if (tile3.Text == tile5.Text && tile3.Text == tile7.Text)
                {
                    if (tile3.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!!!");
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!!!");
                    }
                }
                winner = true;
            }
        }

        private void btn_play_again_Click(object sender, EventArgs e)
        {
            winner = false;
            player_turn = 0;
            tile1.Text = "";
            tile2.Text = "";
            tile3.Text = "";
            tile4.Text = "";
            tile5.Text = "";
            tile6.Text = "";
            tile7.Text = "";
            tile8.Text = "";
            tile9.Text = "";
        }
    }
}
