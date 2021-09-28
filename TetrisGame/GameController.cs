using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TetrisGame
{
    class GameController
    {
        private Timer timer;
        private int level;
        private int score;
        private int speedMaxLevel = 10;
        private int speedInterval = 100;
        private Random random = new Random();

        public Container container { get; private set; }
        public event Action OnNext;
        public event Action OnPropertyChanged;
        public event Action OnGameOver;

        public int Level
        {
            get { return level; }
            private set
            {
                level = value;
                OnPropertyChanged();
            }
        }
        public int Score
        {
            get { return score; }
            private set
            {
                score = value;
                OnPropertyChanged();
            }
        }
        public Type NextType { get; private set; }

        public GameController()
        {
            container = new Container();
        }

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

        public void GameOver()
        {
            timer.Stop();
            timer.Close();
        }

        public void NewTetris()
        {
            if (container.Create(NextType) == false)
            {
                OnGameOver();
                return;
            }
            NextType = (Type)random.Next(Common.typeCount);
            OnNext();
        }


        private void Clear(int clearRows)
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
        private void TimerUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            int clearRows = container.GoDown();
            Clear(clearRows);
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
            Clear(clearRows);
            timer.Start();
        }


    }
}
