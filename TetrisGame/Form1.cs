using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GameStart()
        {

        }


        private void GameOver()
        {

        }










        private void btnStart_Click(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            btnMenu.Visible = false;
            tab.SelectTab(1);
            GameStart();
        }

        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            tab.SelectTab(2);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tab.SelectTab(0);
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            tab.SelectTab(0);
        }
    }
}