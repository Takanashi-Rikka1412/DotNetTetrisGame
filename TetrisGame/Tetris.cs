using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    class Tetris
    {
        public Point[] point;       // 方块各点坐标
        public Type Type { get; }   // 方块类型
        int state;           // 方块旋转4种状态

        public Tetris(Type type)
        {
            this.Type = type;
            state = 0;
            switch (type)
            {
                case Type.I: point = new Point[4] { new Point(1, 1), new Point(1, 2), new Point(1, 3), new Point(1, 4) }; break;
                case Type.O: point = new Point[4] { new Point(1, 1), new Point(1, 2), new Point(2, 1), new Point(2, 2) }; ; break;
                case Type.T: point = new Point[4] { new Point(1, 2), new Point(2, 1), new Point(2, 2), new Point(2, 3) }; ; break;
                case Type.J: point = new Point[4] { new Point(1, 1), new Point(2, 1), new Point(2, 2), new Point(2, 3) }; ; break;
                case Type.L: point = new Point[4] { new Point(1, 3), new Point(2, 1), new Point(2, 2), new Point(2, 3) }; ; break;
                case Type.S: point = new Point[4] { new Point(1, 2), new Point(1, 3), new Point(2, 1), new Point(2, 2) }; ; break;
                case Type.Z: point = new Point[4] { new Point(1, 1), new Point(1, 2), new Point(2, 2), new Point(2, 3) }; ; break;
                default: return;
            }
        }

        // 返回最高行坐标
        public int HighRow()
        {
            int row = point[0].Row;
            foreach (Point p in point)
            {
                if (p.Row < row)
                    row = p.Row;
            }
            return row;
        }
        // 返回最低行坐标
        public int LowRow()
        {
            int row = point[0].Row;
            foreach (Point p in point)
            {
                if (p.Row > row)
                    row = p.Row;
            }
            return row;
        }
        // 返回最左列坐标
        public int LeftCol()
        {
            int col = point[0].Col;
            foreach (Point p in point)
            {
                if (p.Col < col)
                    col = p.Col;
            }
            return col;
        }
        // 返回最右列坐标
        public int RightCol()
        {
            int col = point[0].Col;
            foreach (Point p in point)
            {
                if (p.Col > col)
                    col = p.Col;
            }
            return col;
        }
        // 返回中心点
        public Point CenterPoint()
        {
            switch (state)
            {
                case 0: return new Point(HighRow() + 1, LeftCol() + 1);
                case 1: return new Point(HighRow() + 1, LeftCol());
                case 2: return new Point(HighRow(), LeftCol() + 1);
                case 3: return new Point(HighRow() + 1, LeftCol() + 1);
                default: return null;
            }
        }
        // I型中心点
        public FloatPoint TypeICenterPoint()
        {
            switch (state)
            {
                case 0: return new FloatPoint(HighRow() + 0.5f, 0.5f * (LeftCol() + RightCol()));
                case 1: return new FloatPoint(0.5f * (HighRow() + LowRow()), LeftCol() - 0.5f);
                case 2: return new FloatPoint(HighRow() - 0.5f, 0.5f * (LeftCol() + RightCol()));
                case 3: return new FloatPoint(0.5f * (HighRow() + LowRow()), LeftCol() + 0.5f);
                default: return null;
            }
        }

        // 旋转(逆时针)
        public void Rotate()
        {
            switch (Type)
            {
                case Type.T:
                case Type.J:
                case Type.L:
                case Type.S:
                case Type.Z:
                    Point pCenter = CenterPoint();
                    foreach (Point p in point)
                    {
                        int prow = p.Row;
                        int pcol = p.Col;
                        p.Row = pCenter.Row - (pcol - pCenter.Col);
                        p.Col = pCenter.Col + (prow - pCenter.Row);
                    }
                    break;
                case Type.I:
                    FloatPoint pICenter = TypeICenterPoint();
                    foreach (Point p in point)
                    {
                        int prow = p.Row;
                        int pcol = p.Col;
                        p.Row = (int)(pICenter.Row - (pcol - pICenter.Col));
                        p.Col = (int)(pICenter.Col + (prow - pICenter.Row));
                    }
                    break;
                case Type.O: break;
                default: break;
            }

            ChangeState();
        }

        // 改变旋转状态
        public void ChangeState()
        {
            state = ++state % 4;
        }

        // 调整方块位置（初始化时调用）
        public void Move(Point movePoint)
        {
            foreach (Point p in point)
            {
                p.Row += movePoint.Row;
                p.Col += movePoint.Col;
            }
        }

        // 左移
        public void GoLeft()
        {
            foreach (Point p in point)
            {
                p.GoLeft();
            }
        }
        // 右移
        public void GoRight()
        {
            foreach (Point p in point)
            {
                p.GoRight();
            }
        }
        // 下落
        public void GoDown()
        {
            foreach (Point p in point)
            {
                p.GoDown();
            }
        }


    }
}
