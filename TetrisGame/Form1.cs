using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Form1 : Form
    {
        private GameController gameController;
        private Graphics graphics;
        private Graphics graphicsNext;
        private System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }


        private void GameStart()
        {
            graphics = pnlGame.CreateGraphics();
            graphicsNext = pnlNext.CreateGraphics();

            timer = new System.Timers.Timer(50);
            timer.Elapsed += new ElapsedEventHandler(RefreshContainer);

            gameController = new GameController();
            lblLevelNum.DataBindings.Add("Text", gameController, "Level");
            lblScoreNum.DataBindings.Add("Text", gameController, "Score");
            gameController.OnNext += RefreshContainerNext;

            gameController.GameStart();
            timer.Start();
        }

        
        private void GameOver()
        {
            graphics.Clear(pnlGame.BackColor);
            graphics.Dispose();
            graphicsNext.Clear(pnlNext.BackColor);
            graphicsNext.Dispose();
        }







        private void RefreshContainer(object sender, ElapsedEventArgs e)
        {
            Brush brushColor;
            for (int row = 1; row <= Common.containerHeight; row++)
            {
                for (int col = 1; col <= Common.containerWidth; col++)
                {
                    switch (gameController.container.map[row, col])
                    {
                        case 0: brushColor = Brushes.Cyan; break;
                        case 1: brushColor = Brushes.Yellow; break;
                        case 2: brushColor = Brushes.Purple; break;
                        case 3: brushColor = Brushes.Blue; break;
                        case 4: brushColor = Brushes.Orange; break;
                        case 5: brushColor = Brushes.Green; break;
                        case 6: brushColor = Brushes.Red; break;
                        default: brushColor = new SolidBrush(pnlGame.BackColor); break;
                    }


                    graphics.FillRectangle(brushColor,
                        new Rectangle((col - 1) * pnlGame.Width / Common.containerWidth + 1,
                        (row - 1) * pnlGame.Height / Common.containerHeight + 1,
                        pnlGame.Width / Common.containerWidth - 2,
                        pnlGame.Height / Common.containerHeight - 2));
                }
            }
        }

        private void RefreshContainerNext()
        {
            graphicsNext.Clear(pnlNext.BackColor);
            Brush brushColor;
            switch ((int)gameController.NextType)
            {
                case 0: brushColor = Brushes.Cyan; break;
                case 1: brushColor = Brushes.Yellow; break;
                case 2: brushColor = Brushes.Purple; break;
                case 3: brushColor = Brushes.Blue; break;
                case 4: brushColor = Brushes.Orange; break;
                case 5: brushColor = Brushes.Green; break;
                case 6: brushColor = Brushes.Red; break;
                default: brushColor = new SolidBrush(pnlNext.BackColor); break;
            }
            foreach (Point p in new Tetris(gameController.NextType).point)
            {
                graphicsNext.FillRectangle(brushColor,
                    new Rectangle((p.Col - 1) * pnlNext.Width / Common.nextPanelWidth + 1,
                    p.Row * pnlNext.Height / Common.nextPanelHeight + 1,
                    pnlNext.Width / Common.nextPanelWidth - 2,
                    pnlNext.Height / Common.nextPanelHeight - 2));
            }

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