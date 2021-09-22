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
        private Container container;
        private Timer timer;

        public int Speed { get; private set; }
        public int Score { get; private set; }

        public GameController()
        {
            timer = new Timer(100);
            container = new Container();
        }

        public void GameStart()
        {
            Speed = 1;
            Score = 0;
            timer.Start();
            
        }



    }
}
