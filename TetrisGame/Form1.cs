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
        private GameState gameState = GameState.Stop;
        private delegate void RefreshTextInvokeCallback();


        public Form1()
        {
            InitializeComponent();
        }

        // 游戏开始
        private void GameStart()
        {
            graphics = pnlGame.CreateGraphics();
            graphicsNext = pnlNext.CreateGraphics();

            timer = new System.Timers.Timer(50);
            timer.Elapsed += new ElapsedEventHandler(RefreshContainer);

            gameController = new GameController();
            gameController.OnNext += RefreshContainerNext;
            gameController.OnPropertyChanged += RefreshText;

            gameController.GameStart();
            gameState = GameState.Start;
            timer.Start();
        }


        private void GameOver()
        {
            graphics.Clear(pnlGame.BackColor);
            graphics.Dispose();
            graphicsNext.Clear(pnlNext.BackColor);
            graphicsNext.Dispose();
        }






        // 刷新方块界面
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
        // 刷新下一个方块提示界面
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
        // 刷新等级和分数等
        private void RefreshText()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new RefreshTextInvokeCallback(RefreshText));
            }
            else
            {
                lblLevelNum.Text = gameController.Level.ToString();
                lblScoreNum.Text = gameController.Score.ToString();
            }
        }

        // 开始按钮
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            btnMenu.Visible = false;
            tab.SelectTab(1);
            GameStart();
        }
        // 排行榜按钮
        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            tab.SelectTab(2);
        }
        // 退出按钮
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        // 重新开始按钮
        private void btnRestart_Click(object sender, EventArgs e)
        {
            GameStart();
        }
        // 游戏中返回菜单按钮
        private void btnMenu_Click(object sender, EventArgs e)
        {
            tab.SelectTab(0);
        }
        // 排行榜中返回菜单按钮
        private void btnMenu2_Click(object sender, EventArgs e)
        {
            tab.SelectTab(0);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (gameState != GameState.Start)
                return;
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    break;
                case Keys.A:
                case Keys.Left:
                    gameController.GoLeft();
                    break;
                case Keys.D:
                case Keys.Right:
                    gameController.GoRight();
                    break;
                case Keys.S:
                case Keys.Down:
                    gameController.GoDownDirectly();
                    break;
                default: break;
            }
        }

    }
}