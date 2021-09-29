using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TetrisGame
{
    class GameController
    {
        private Timer timer;              // 方块下落计时器
        private int level;
        private int score;
        private int speedMaxLevel = 10;
        private int speedInterval = 100;
        private Random random = new Random();


        public Container container { get; private set; }  // 容器
        public event Action OnNext;                       // 下一个方块事件
        public event Action OnPropertyChanged;            // 等级、分数改变事件
        public event Action OnGameOver;                   // 游戏结束事件

        // 难度等级
        public int Level
        {
            get { return level; }
            private set
            {
                level = value;
                OnPropertyChanged();
            }
        }
        // 分数
        public int Score
        {
            get { return score; }
            private set
            {
                score = value;
                OnPropertyChanged();
            }
        }
        // 下一个方块类型
        public Type NextType { get; private set; }

        // 构造方法
        public GameController()
        {
            container = new Container();
        }



        // 游戏开始
        public void GameStart()
        {
            Level = 1;
            Score = 0;
            timer = new Timer((speedMaxLevel + 1 - Level) * speedInterval);
            timer.Elapsed += new ElapsedEventHandler(TimerUp);
            NextType = (Type)random.Next(Common.typeCount);
            NewTetris();
            timer.Start();
        }
        // 游戏结束
        public void GameOver()
        {
            timer.Stop();
            timer.Close();
        }
        // 游戏暂停
        public void Pause()
        {
            timer.Stop();
        }
        // 游戏继续
        public void Continue()
        {
            timer.Start();
        }

        // 旋转
        public void Rotate()
        {

            container.Rotate();
        }
        // 左移
        public void GoLeft()
        {

            container.GoLeft();
        }
        // 右移
        public void GoRight()
        {

            container.GoRight();
        }
        // 直接下落
        public void GoDownDirectly()
        {
            timer.Stop();
            int clearRows = container.GoDownDirectly();
            ScoreWhenClear(clearRows);
            timer.Start();
        }






        // 创建新方块
        private void NewTetris()
        {
            if (container.Create(NextType) == false)
            {
                OnGameOver();   // 无法创建新方块时时游戏结束
                return;
            }
            NextType = (Type)random.Next(Common.typeCount);
            OnNext();
        }
        // 方块下落计时器处理
        private void TimerUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            int clearRows = container.GoDown();
            ScoreWhenClear(clearRows);
        }
        // 消除方块时的加分、加速
        private void ScoreWhenClear(int clearRows)
        {
            switch (clearRows)
            {
                case 0: break;
                case 1: Score += 100; break;
                case 2: Score += 300; break;
                case 3: Score += 500; break;
                case 4: Score += 800; break;
                case -1:
                default:
                    return;
            }
            if (Score >= Level * 1000 && Level < 10)
            {
                Level++;
                timer.Stop();
                timer.Close();
                timer = new Timer((speedMaxLevel + 1 - Level) * speedInterval);
                timer.Elapsed += new ElapsedEventHandler(TimerUp);
                timer.Start();
            }

            NewTetris();
        }
    }
}
