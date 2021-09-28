using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private System.Timers.Timer playingTimer;
        private System.Timers.Timer restartTimer;
        private GameState gameState = GameState.Stop;
        private delegate void InvokeCallback();


        private System.Drawing.Point mousePoint;



        public Form1()
        {
            InitializeComponent();
            graphics = pnlGame.CreateGraphics();
            graphicsNext = pnlNext.CreateGraphics();
        }

        // 游戏开始
        private void GameStart()
        {
            graphics.Clear(pnlGame.BackColor);
            graphicsNext.Clear(pnlNext.BackColor);


            playingTimer = new System.Timers.Timer(50);
            playingTimer.Elapsed += new ElapsedEventHandler(RefreshContainer);

            gameController = new GameController();
            gameController.OnNext += RefreshContainerNext;
            gameController.OnPropertyChanged += RefreshText;
            gameController.OnGameOver += GameOver;

            gameController.GameStart();
            gameState = GameState.Start;
            playingTimer.Start();
        }


        private void GameOver()
        {
            gameState = GameState.Stop;
            playingTimer.Stop();
            gameController.GameOver();
            playingTimer.Close();


            if (this.InvokeRequired)
            {
                this.Invoke(new InvokeCallback(() => {
                    picGameOver.Visible = true;
                }));
            }
            else
            {
                picGameOver.Visible = true;
            }

            restartTimer = new System.Timers.Timer(2000);
            restartTimer.Elapsed += new ElapsedEventHandler(ReadytoRestart);
            restartTimer.AutoReset = false;
            restartTimer.Start();
        }

        public void ReadytoRestart(object sender, ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new InvokeCallback(() => {
                    btnRestart.Visible = true;
                    btnMenu.Visible = true;
                }));
            }
            else
            {
                btnRestart.Visible = true;
                btnMenu.Visible = true;
            }
            restartTimer.Close();
        }





        // 刷新方块界面
        private void RefreshContainer(object sender, ElapsedEventArgs e)
        {
            lock (graphics)
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
                            case 2: brushColor = Brushes.MediumPurple; break;
                            case 3: brushColor = Brushes.DeepSkyBlue; break;
                            case 4: brushColor = Brushes.Orange; break;
                            case 5: brushColor = Brushes.LawnGreen; break;
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
        }
        // 刷新下一个方块提示界面
        private void RefreshContainerNext()
        {
            lock (graphicsNext)
            {
                graphicsNext.Clear(pnlNext.BackColor);
                Brush brushColor;
                switch ((int)gameController.NextType)
                {
                    case 0: brushColor = Brushes.Cyan; break;
                    case 1: brushColor = Brushes.Yellow; break;
                    case 2: brushColor = Brushes.MediumPurple; break;
                    case 3: brushColor = Brushes.DeepSkyBlue; break;
                    case 4: brushColor = Brushes.Orange; break;
                    case 5: brushColor = Brushes.LawnGreen; break;
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

        }
        // 刷新等级和分数等
        private void RefreshText()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new InvokeCallback(RefreshText));
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
            picGameOver.Visible = false;
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
            picGameOver.Visible = false;
            btnRestart.Visible = false;
            btnMenu.Visible = false;
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

        // 获取键盘输入
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (gameState != GameState.Start)
                return;
            
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    gameController.Rotate();
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

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new System.Drawing.Point(this.Location.X + e.X - mousePoint.X, this.Location.Y + e.Y - mousePoint.Y);
        }

    }
}