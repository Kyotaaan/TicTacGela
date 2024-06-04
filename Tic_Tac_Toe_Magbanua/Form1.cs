using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Magbanua
{
    public partial class Form1 : Game_Methods
    {
        protected string bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9;
        private bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
            bt1 = "";
            bt2 = "";
            bt3 = "";
            bt4 = "";
            bt5 = "";
            bt6 = "";
            bt7 = "";
            bt8 = "";
            bt9 = "";
        }

        bool isPlayerX = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b1.Text = "X";
            }
            else
            {
                b1.Text = "O";
            }

            b1.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b2.Text = "X";
            }
            else
            {
                b2.Text = "O";
            }

            b2.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b3.Text = "X";
            }
            else
            {
                b3.Text = "O";
            }

            b3.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b4.Text = "X";
            }
            else
            {
                b4.Text = "O";
            }

            b4.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b5.Text = "X";
            }
            else
            {
                b5.Text = "O";
            }

            b5.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b6.Text = "X";
            }
            else
            {
                b6.Text = "O";
            }

            b6.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b7.Text = "X";
            }
            else
            {
                b7.Text = "O";
            }

            b7.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b8.Text = "X";
            }
            else
            {
                b8.Text = "O";
            }

            b8.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (isPlayerX)
            {
                b9.Text = "X";
            }
            else
            {
                b9.Text = "O";
            }

            b9.Enabled = false;
            Update_Game();
            label4.Text = checkWin();
            if (label4.Text != "")
            {
                gameOver = true;
                Off_All_Buttons();
            }
            isPlayerX = !isPlayerX;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reset_Game();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit Game", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public override void Update_Game()
        {
            bt1 = b1.Text;
            bt2 = b2.Text;
            bt3 = b3.Text;
            bt4 = b4.Text;
            bt5 = b5.Text;
            bt6 = b6.Text;
            bt7 = b7.Text;
            bt8 = b8.Text;
            bt9 = b9.Text;
        }

        public override void Off_All_Buttons()
        {
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
        }

        public override void Reset_Game()
        {
            bt1 = bt2 = bt3 = bt4 = bt5 = bt6 = bt7 = bt8 = bt9 = "";
            isPlayerX = true;
            gameOver = false;

            b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";
            b1.Enabled = b2.Enabled = b3.Enabled = b4.Enabled = b5.Enabled = b6.Enabled = b7.Enabled = b8.Enabled = b9.Enabled = true;
            label4.Text = "";
        }

        public override string checkWin()
        {
            if (!string.IsNullOrEmpty(bt1) && bt1 == bt2 && bt2 == bt3)
            {
                return $"Player {bt1} Wins!";
            }
            else if (!string.IsNullOrEmpty(bt1) && bt1 == bt4 && bt4 == bt7)
            {
                return $"Player {bt1} Wins!";
            }
            else if (!string.IsNullOrEmpty(bt1) && bt1 == bt5 && bt5 == bt9)
            {
                return $"Player {bt1} Wins!";
            }
            else if (!string.IsNullOrEmpty(bt4) && bt4 == bt5 && bt5 == bt6)
            {
                return $"Player {bt4} Wins!";
            }
            else if (!string.IsNullOrEmpty(bt7) && bt7 == bt8 && bt8 == bt9)
            {
                return $"Player {bt7} Wins!";
            }
            else if (!string.IsNullOrEmpty(bt2) && bt2 == bt5 && bt5 == bt8)
            {
                return $"Player {bt2} Wins!";
            }
            else if (!string.IsNullOrEmpty(bt3) && bt3 == bt6 && bt6 == bt9)
            {
                return $"Player {bt3} Wins!";
            }
            else if (!string.IsNullOrEmpty(bt3) && bt3 == bt5 && bt5 == bt7)
            {
                return $"Player {bt3} Wins!";
            }
            else
            {
                return "";
            }
        }
    }

    public abstract class Game_Methods : Form
    {
        public abstract void Update_Game();
        public abstract void Off_All_Buttons();
        public abstract void Reset_Game();
        public abstract string checkWin();
    }
}