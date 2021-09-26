using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TetrisGame
{
    class GameController
    {
        private Timer timer;
        private int speedMaxLevel = 10;
        private int speedInterval = 100;
        private Random random = new Random();

        public Container container;
        public event Action OnNext;

        public int Level { get; private set; }
        public int Score { get; private set; }
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

        public void NewTetris()
        {
            container.Create(NextType);
            NextType = (Type)random.Next(Common.typeCount);
            OnNext();
        }


        private void TimerUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            int clearRows = container.GoDown();
            switch (clearRows)
            {
                case 0:break;
                case 1:Score += 100;break;
                case 2:Score += 300;break;
                case 3:Score += 500;break;
                case 4:Score += 800;break;
                case -1:
                default:
                    return;
            }
            if (Score >= Level * 1000 && Level < 10)
                Level++;
            NewTetris();
        }

        

    }
}
