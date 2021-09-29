using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    [Serializable]
    public class ScoreRank
    {
        //public int Rank { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public ScoreRank()
        {
            Name = "";
            Score = 0;
        }
    }
}
