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
          
            
        }

        private void tile2_Click(object sender, EventArgs e)
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

        private void tile3_Click(object sender, EventArgs e)
        {

        }

        private void tile4_Click(object sender, EventArgs e)
        {

        }

        private void tile5_Click(object sender, EventArgs e)
        {

        }

        private void tile6_Click(object sender, EventArgs e)
        {

        }

        private void tile7_Click(object sender, EventArgs e)
        {

        }

        private void tile8_Click(object sender, EventArgs e)
        {

        }

        private void tile9_Click(object sender, EventArgs e)
        {

        }
    }
}
