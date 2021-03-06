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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    
                    tile1.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile2.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile3.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile4.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile5.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile6.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile7.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile8.Text = "O";
                    turn_txtbox.Text = "X Turn";
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
                    turn_txtbox.Text = "O Turn";
                    player_turn++;
                }
                else
                {
                    tile9.Text = "O";
                    turn_txtbox.Text = "X Turn";
                    player_turn++;
                }
            }
            check_winner();
        }

        public void Stop_Turn()
        {
            tile1.Enabled = false;
            tile2.Enabled = false;
            tile3.Enabled = false;
            tile4.Enabled = false;
            tile5.Enabled = false;
            tile6.Enabled = false;
            tile7.Enabled = false;
            tile8.Enabled = false;
            tile9.Enabled = false;
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
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();
                }
                winner = true;
                
            }
            if (tile4.Text != "" && tile5.Text != "" && tile6.Text != "")
            {
                if (tile4.Text == tile5.Text && tile4.Text == tile6.Text)
                {
                    if (tile4.Text == "X")
                    {
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();

                }
                winner = true;
            }
            if (tile7.Text != "" && tile8.Text != "" && tile9.Text != "")
            {
                if (tile7.Text == tile8.Text && tile7.Text == tile9.Text)
                {
                    if (tile7.Text == "X")
                    {
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();
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
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();
                }
                winner = true;
            }
            if (tile2.Text != "" && tile5.Text != "" && tile8.Text != "")
            {
                if (tile2.Text == tile5.Text && tile2.Text == tile8.Text)
                {
                    if (tile2.Text == "X")
                    {
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();
                }
                winner = true;
            }
            if (tile3.Text != "" && tile6.Text != "" && tile9.Text != "")
            {
                if (tile3.Text == tile6.Text && tile3.Text == tile9.Text)
                {
                    if (tile3.Text == "X")
                    {
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();
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
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();
                }
                winner = true;
            }
            if (tile3.Text != "" && tile5.Text != "" && tile7.Text != "")
            {
                if (tile3.Text == tile5.Text && tile3.Text == tile7.Text)
                {
                    if (tile3.Text == "X")
                    {
                        DisplayBox.Text = "Player X Wins!!!";
                    }
                    else
                    {
                        DisplayBox.Text = "Player O Wins!!!";
                    }
                    Stop_Turn();
                }
                
                winner = true;
            }

            //check draw
            if (player_turn == 9)
            {
                DisplayBox.Text = "Draw!!";
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
            DisplayBox.Text = "";
            turn_txtbox.Text = "X Turn";
            tile1.Enabled = true;
            tile2.Enabled = true;
            tile3.Enabled = true;
            tile4.Enabled = true;
            tile5.Enabled = true;
            tile6.Enabled = true;
            tile7.Enabled = true;
            tile8.Enabled = true;
            tile9.Enabled = true;
        }       
    }
}
