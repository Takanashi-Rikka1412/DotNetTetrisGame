using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    class Container
    {
        public int[,] map;
        Tetris tetris;
        //State tetrisState;
        public Container()
        {
            map = new int[Common.containerHeight + 1, Common.containerWidth + 1];
            for (int row = 1; row <= Common.containerHeight; row++)
            {
                for (int col = 1; col <= Common.containerWidth; col++)
                {
                    map[row, col] = -1;
                }
            }
            tetris = null;
        }


        public void Create(Type type)
        {
            tetris = new Tetris(type);
            int col = (Common.containerWidth - tetris.RightCol() + tetris.LeftCol() - 1) / 2;
            tetris.Move(new Point(0, col));

            foreach (Point p in tetris.point)
            {
                map[p.Row, p.Col] = (int)type;
            }

        }



        // 检测与其他方块的碰撞
        public bool Collide(Move move)
        {
            switch (move)
            {
                case Move.LEFT:
                    if (tetris.LeftCol() <= 1)
                        return true;
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row, p.Col - 1] >= 0 && !tetris.point.Contains(new Point(p.Row, p.Col - 1)))
                            return true;
                    }
                    return false;
                case Move.RIGHT:
                    if (tetris.RightCol() >= Common.containerWidth)
                        return true;
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row, p.Col + 1] >= 0 && !tetris.point.Contains(new Point(p.Row, p.Col + 1)))
                            return true;
                    }
                    return false;
                case Move.DOWN:
                    if (tetris.LowRow() >= Common.containerHeight)
                        return true;
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row + 1, p.Col] >= 0 && !tetris.point.Contains(new Point(p.Row + 1, p.Col)))
                            return true;
                    }
                    return false;
                case Move.STAY:
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row, p.Col] >= 0 && !tetris.point.Contains(new Point(p.Row, p.Col)))
                            return true;
                    }
                    return false;
                default: return true;
            }
        }

        // 将map上的颜色消除
        public void DePaint()
        {
            foreach (Point p in tetris.point)
            {
                map[p.Row, p.Col] = -1;
            }
        }

        // 在map上添加方块颜色
        public void Paint()
        {
            foreach (Point p in tetris.point)
            {
                map[p.Row, p.Col] = (int)tetris.Type;
            }
        }

        // 左移
        public void GoLeft()
        {
            if (Collide(Move.LEFT))
                return;

            DePaint();

            tetris.GoLeft();

            Paint();
        }
        // 右移
        public void GoRight()
        {
            if (Collide(Move.RIGHT))
                return;

            DePaint();

            tetris.GoRight();

            Paint();
        }
        // 下落
        public int GoDown()
        {
            if (Collide(Move.DOWN))
            {
                return DropOnGround();
            }

            DePaint();

            tetris.GoDown();

            Paint();

            return -1;
        }
        // 直接下落
        public int GoDownDirectly()
        {
            DePaint();

            while (!Collide(Move.DOWN))
                tetris.GoDown();

            Paint();

            return DropOnGround();
        }
        // 落地
        public int DropOnGround()
        {
            List<int> rows = ClearCheck();
            if (rows.Count <= 0)
                return 0;
            foreach (int row in rows)
            {
                Clear(row);
            }


            for (int row = rows.Max(), i = 1; row >= 1; row--)
            {
                if (rows.Contains(row - i))
                    i++;
                if (row - i < 1)
                {
                    for (int col = 1; col <= Common.containerHeight; col++)
                    {
                        map[row, col] = -1;
                    }
                }
                else
                {
                    for (int col = 1; col <= Common.containerHeight; col++)
                    {
                        map[row, col] = map[row - i, col];
                    }
                }

            }

            return rows.Count;
        }

        // 消除检查
        public List<int> ClearCheck()
        {
            List<int> rows = new List<int>();
            for (int row = 1; row <= Common.containerHeight; row++)
            {
                int col = 1;
                for (; col <= Common.containerWidth; col++)
                {
                    if (map[row, col] == -1)
                        break;
                }
                if (col <= Common.containerWidth)
                    continue;
                else
                    rows.Add(row);
            }

            return rows;
        }

        // 消除
        public void Clear(int row)
        {
            for (int col = 1; col <= Common.containerWidth; col++)
            {
                map[row, col] = -1;
            }
        }
    }
}



