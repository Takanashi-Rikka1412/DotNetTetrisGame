using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Form1 : Form
    {
        private GameController gameController;        // 游戏控制器
        private Graphics graphics;                    // 绘图板
        private Graphics graphicsNext;                // 绘图板（next提示）
        private System.Timers.Timer playingTimer;     // 绘图板刷新计时器
        private System.Timers.Timer restartTimer;     // 结束后重启计时器
        private ScoreRank[] scoreBoard;               // 排行榜
        private GameState gameState = GameState.Stop; // 游戏状态

        private System.Drawing.Point mousePoint;
        private delegate void InvokeCallback();
        private delegate void InvokeCallbackBoolArg(bool b);


        public Form1()
        {
            InitializeComponent();
            graphics = pnlGame.CreateGraphics();
            graphicsNext = pnlNext.CreateGraphics();


            LoadScoreBoard();

        }

        public void Init()
        {
            btnPauseOrContinue.Image = Properties.Resources.ButtonPause;
            btnRestart.Visible = false;
            btnMenu.Visible = false;
            picGameOver.Visible = false;
            picPause.Visible = false;
        }

        // 游戏开始
        public void GameStart()
        {
            Init();

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
        // 游戏结束
        public void GameOver()
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
        // 重启处理
        private void ReadytoRestart(object sender, ElapsedEventArgs e)
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
            restartTimer.Stop();
            restartTimer.Close();

            CheckRecord();
        }
        // 游戏暂停
        public void GamePause()
        {
            gameState = GameState.Pause;
            playingTimer.Stop();
            gameController.Pause();


            picPause.Visible = true;
            
        }
        // 游戏继续
        public void GameContinue()
        {
            picPause.Visible = false;

            gameController.Continue();
            playingTimer.Start();
            gameState = GameState.Start;

        }
        // 加载排行榜
        public void LoadScoreBoard()
        {
            scoreBoard = new ScoreRank[10]
            {
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank(),
                new ScoreRank()
            };
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("scoreboard.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                    scoreBoard = (ScoreRank[])binaryFormatter.Deserialize(fs);
            }
        }
        // 展示排行榜
        public void ShowScoreBoard()
        {
            if (scoreBoard[0].Score == 0)
                return;
            lblName1.Text = scoreBoard[0].Name;
            lblScore1.Text = scoreBoard[0].Score.ToString();
            if (scoreBoard[1].Score == 0)
                return;
            lblName2.Text = scoreBoard[1].Name;
            lblScore2.Text = scoreBoard[1].Score.ToString();
            if (scoreBoard[2].Score == 0)
                return;
            lblName3.Text = scoreBoard[2].Name;
            lblScore3.Text = scoreBoard[2].Score.ToString();
            if (scoreBoard[3].Score == 0)
                return;
            lblName4.Text = scoreBoard[3].Name;
            lblScore4.Text = scoreBoard[3].Score.ToString();
            if (scoreBoard[4].Score == 0)
                return;
            lblName5.Text = scoreBoard[4].Name;
            lblScore5.Text = scoreBoard[4].Score.ToString();
            if (scoreBoard[5].Score == 0)
                return;
            lblName6.Text = scoreBoard[5].Name;
            lblScore6.Text = scoreBoard[5].Score.ToString();
            if (scoreBoard[6].Score == 0)
                return;
            lblName7.Text = scoreBoard[6].Name;
            lblScore7.Text = scoreBoard[6].Score.ToString();
            if (scoreBoard[7].Score == 0)
                return;
            lblName8.Text = scoreBoard[7].Name;
            lblScore8.Text = scoreBoard[7].Score.ToString();
            if (scoreBoard[8].Score == 0)
                return;
            lblName9.Text = scoreBoard[8].Name;
            lblScore9.Text = scoreBoard[8].Score.ToString();
            if (scoreBoard[9].Score == 0)
                return;
            lblName10.Text = scoreBoard[9].Name;
            lblScore10.Text = scoreBoard[9].Score.ToString();

        }
        // 存储排行榜
        public void SaveScoreBoard()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("scoreboard.dat", FileMode.Create))
            {
                binaryFormatter.Serialize(fs,scoreBoard);
            }
        }
        // 检查是否破纪录
        public void CheckRecord()
        {
            if (gameController.Score > 0)
            {
                ScoreRank scoreRank = new ScoreRank();
                scoreRank.Score = gameController.Score;
                for (int i = 0; i < scoreBoard.Length; i++)
                {
                    if (scoreRank.Score > scoreBoard[i].Score)
                    {
                        SetAllButtonEnable(false);

                        ScoreForm scoreForm = new ScoreForm(scoreRank);

                        if (scoreForm.ShowDialog() == DialogResult.OK)
                        {
                            for (int j = scoreBoard.Length - 1; j > i; j--)
                            {
                                scoreBoard[j] = scoreBoard[j - 1];
                            }
                            scoreBoard[i] = scoreRank;
                        }


                        SetAllButtonEnable(true);

                        break;
                    }
                }

            }
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
                        switch (gameController.map[row, col])
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
                PointF temp;
                switch (gameController.NextType)
                {
                    case Type.I:
                        brushColor = Brushes.Cyan;
                        temp = new PointF(-1,0.5f);
                        break;
                    case Type.O:
                        brushColor = Brushes.Yellow;
                        temp = new PointF(0, 0);
                        break;
                    case Type.T:
                        brushColor = Brushes.MediumPurple;
                        temp = new PointF(-0.5f, 0);
                        break;
                    case Type.J:
                        brushColor = Brushes.DeepSkyBlue;
                        temp = new PointF(-0.5f, 0);
                        break;
                    case Type.L:
                        brushColor = Brushes.Orange;
                        temp = new PointF(-0.5f, 0);
                        break;
                    case Type.S:
                        brushColor = Brushes.LawnGreen;
                        temp = new PointF(-0.5f, 0);
                        break;
                    case Type.Z:
                        brushColor = Brushes.Red;
                        temp = new PointF(-0.5f, 0);
                        break;
                    default:
                        brushColor = new SolidBrush(pnlNext.BackColor);
                        temp = new PointF(0,0);
                        break;
                }
                foreach (Point p in new Tetris(gameController.NextType).point)
                {
                    graphicsNext.FillRectangle(brushColor,
                        new Rectangle
                        (
                            (int)((p.Col + temp.X) * pnlNext.Width / Common.nextPanelWidth + 1),
                            (int)((p.Row+temp.Y) * pnlNext.Height / Common.nextPanelHeight + 1),
                            pnlNext.Width / Common.nextPanelWidth - 2,
                            pnlNext.Height / Common.nextPanelHeight - 2
                        )
                    );

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
            tab.SelectTab(1);
            GameStart();
        }
        // 排行榜按钮
        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            ShowScoreBoard();
            tab.SelectTab(2);
        }
        // 退出按钮
        private void btnQuit_Click(object sender, EventArgs e)
        {
            SaveScoreBoard();
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
            if(gameState != GameState.Stop)
            {
                gameState = GameState.Stop;
                playingTimer.Stop();
                gameController.GameOver();
                playingTimer.Close();
            }

            tab.SelectTab(0);
        }
        // 暂停或继续按钮
        private void btnPauseOrContinue_Click(object sender, EventArgs e)
        {
            if(gameState == GameState.Start)
            {
                GamePause();
                btnPauseOrContinue.Image = Properties.Resources.ButtonContinue;
                btnMenu.Visible = true;
            }
            else if(gameState == GameState.Pause)
            {
                btnMenu.Visible = false;
                btnPauseOrContinue.Image = Properties.Resources.ButtonPause;
                GameContinue();
            }
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


        // 重写窗体的事件
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            SaveScoreBoard();
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
        private void SetAllButtonEnable(bool enabled)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new InvokeCallbackBoolArg(SetAllButtonEnable), enabled);
            }
            else
            {
                //btnCloseForm.Enabled = enabled;
                btnMenu.Enabled = enabled;
                btnMenu2.Enabled = enabled;
                btnMinForm.Enabled = enabled;
                btnPauseOrContinue.Enabled = enabled;
                btnQuit.Enabled = enabled;
                btnRestart.Enabled = enabled;
                btnScoreBoard.Enabled = enabled;
                btnStart.Enabled = enabled;
            }

        }

    }
}