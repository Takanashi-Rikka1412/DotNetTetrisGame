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
        private int _row;
        private int _col;
        public int Row
        {
            get => _row;
            set => _row = (value > 0 && value <= Common.conatinerHeight) ? value : 1;
        }
        public int Col
        {
            get => _col;
            set => _col = (value > 0 && value <= Common.conatinerWidth) ? value : 1;
        }
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

        /*
        //将行与列对换
        public void Reverse()
        {
            int p = Row;
            Row = Col;
            Col = p;
        }
        //加减等号重载
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.Row + p2.Row, p1.Col + p2.Col);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.Row - p2.Row, p1.Col - p2.Col);
        }
        */


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

