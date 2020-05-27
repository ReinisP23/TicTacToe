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
        bool playerX = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            InitializeCells();
        }
        private void InitializeGrid()
        {
            Grid.BackColor = Color.Coral;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Player_Cick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text != string.Empty)
            {
                return;
            }
            if (playerX)
            {
                label.Text = "X";
            }
            else
            {
                label.Text = "O";
            }
            CheckWin();
            turnCount++;
            CheckDraw();
            playerX = !playerX;
        }
        private void InitializeCells()
        {
            string labelText;
            for (int i = 1; i <= 9; i++)
            {
                labelText = "label" + i;
                Grid.Controls[labelText].Text = string.Empty;
                Grid.Controls[labelText].BackColor = Color.Coral;
            }
        }
        private void CheckWin()
        {
            if (
                (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != string.Empty) ||
                (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != string.Empty) ||
                (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != string.Empty) ||
                (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != string.Empty) ||
                (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != string.Empty) ||
                (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != string.Empty) ||
                (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != string.Empty) ||
                (label3.Text == label5.Text && label5.Text == label7.Text && label3.Text != string.Empty)
               )
            {
                GameOver();
            }
        }
        private void ChangeWinColor()
        {
            if (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != string.Empty)
            {
                ChangeColor(label1, label2, label3, Color.Red);
            }
            else if (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != string.Empty)
            {
                ChangeColor(label4, label5, label6, Color.Red);
            }
            else if (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != string.Empty)
            {
                ChangeColor(label7, label8, label9, Color.Red);
            }
            else if (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != string.Empty)
            {
                ChangeColor(label1, label4, label7, Color.Red);
            }
            else if (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != string.Empty)
            {
                ChangeColor(label2, label5, label8, Color.Red);
            }
            else if (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != string.Empty)
            {
                ChangeColor(label3, label6, label9, Color.Red);
            }
            else if (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != string.Empty)
            {
                ChangeColor(label1, label5, label9, Color.Red);
            }
            else if (label3.Text == label5.Text && label5.Text == label7.Text && label3.Text != string.Empty)
            {
                ChangeColor(label3, label5, label7, Color.Red);
            }
        }
        private void ChangeColor(Label labelOne, Label labelTwo, Label labelThree, Color color)
        {
            labelOne.BackColor = color;
            labelTwo.BackColor = color;
            labelThree.BackColor = color;
        }
        private void CheckDraw()
        {
            if (turnCount == 10)
            {
                MessageBox.Show("Draw!");
                RestartGame();
            }
        }
        private void RestartGame()
        {
            InitializeCells();
            turnCount = 0;
            playerX = true;
        }
        private void GameOver()
        {
            string winner;
            if (playerX)
            {
                winner = "X";
            }
            else
            {
                winner = "O";
            }
            ChangeWinColor();
            MessageBox.Show(winner + " wins!");
            RestartGame();
        }
    }
}
