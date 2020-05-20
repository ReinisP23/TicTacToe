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
            if (playerX)
            {
                label.Text = "X";
            }
            else
            {
                label.Text = "O";
            }
            playerX = !playerX;
        }
        private void InitializeCells()
        {
            string labelText;
            for (int i = 1; i <= 9; i++)
            {
                labelText = "label" + i;
                Grid.Controls[labelText].Text = string.Empty;
            }
        }
    }
}
