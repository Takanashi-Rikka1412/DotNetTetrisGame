using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    //方块的每一个小方块，与坐标点不同，只有正整数，
    //且从上往下，第一行第二格即为（1,2）
    class Point
    {
        public int Row{get; set;}
        public int Col{ get; set; }
        public Point(int row, int col)
        {
            Row = row;
            Col = col;
        }
        public Point(Point point)
        {
            Row = point.Row;
            Col = point.Col;
        }


        public void GoUp()
        {
            Row--;
        }
        public void GoDown()
        {
            Row++;
        }
        public void GoLeft()
        {
            Col--;
        }
        public void GoRight()
        {
            Col++;
        }


        public override bool Equals(object obj)
        {
            var point = obj as Point;
            return point != null &&
                   Row == point.Row &&
                   Col == point.Col;
        }

        public override int GetHashCode()
        {
            var hashCode = 1084646500;
            hashCode = hashCode * -1521134295 + Row.GetHashCode();
            hashCode = hashCode * -1521134295 + Col.GetHashCode();
            return hashCode;
        }
    }

    class FloatPoint
    {
        public float Row;
        public float Col;
        public FloatPoint(float row, float col)
        {
            Row = row;
            Col = col;
        }
        public FloatPoint(FloatPoint point)
        {
            Row = point.Row;
            Col = point.Col;
        }
    }
}

