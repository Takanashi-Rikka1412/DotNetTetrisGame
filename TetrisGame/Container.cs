using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    class Container
    {
        public int[,] map;    // 点阵地图
        Tetris tetris;        // 正在下落的方块

        public Container()
        {
            map = new int[Common.containerHeight + 1, Common.containerWidth + 1];
            for (int row = 0; row <= Common.containerHeight; row++)
            {
                for (int col = 0; col <= Common.containerWidth; col++)
                {
                    map[row, col] = -1;
                }
            }
            tetris = null;
        }


        // 创建新方块
        public bool Create(Type type)
        {
            tetris = new Tetris(type);
            int col = (Common.containerWidth - tetris.RightCol() + tetris.LeftCol() - 1) / 2;
            tetris.Move(new Point(0, col));

            if (GameOverCheck())   // 无法再新建方块时游戏结束
                return false;


            AddToMap();

            return true;
        }

        // 旋转
        public void Rotate()
        {
            Point[] pTemp = new Point[4]
            {
                new Point(tetris.point[0]),
                new Point(tetris.point[1]),
                new Point(tetris.point[2]),
                new Point(tetris.point[3]),};

            DeleteFromMap();

            tetris.Rotate();

            if(Collide(Move.STAY))
            {
                tetris.point = pTemp;
            }
            else
            {
                tetris.ChangeState();
            }

            AddToMap();

        }

        // 左移
        public void GoLeft()
        {
            if (Collide(Move.LEFT))
                return;

            DeleteFromMap();

            tetris.GoLeft();

            AddToMap();
        }
        // 右移
        public void GoRight()
        {
            if (Collide(Move.RIGHT))
                return;

            DeleteFromMap();

            tetris.GoRight();

            AddToMap();
        }
        // 下落
        public int GoDown()
        {
            if (Collide(Move.DOWN))
            {
                return DropOnGround();
            }

            DeleteFromMap();

            tetris.GoDown();

            AddToMap();

            return -1;
        }
        // 直接下落
        public int GoDownDirectly()
        {
            DeleteFromMap();

            while (!Collide(Move.DOWN))
                tetris.GoDown();

            AddToMap();

            return DropOnGround();
        }







        // 落地
        private int DropOnGround()
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
                while(rows.Contains(row - i))
                    i++;
                if (row - i < 1)
                {
                    for (int col = 1; col <= Common.containerWidth; col++)
                    {
                        map[row, col] = -1;
                    }
                }
                else
                {
                    for (int col = 1; col <= Common.containerWidth; col++)
                    {
                        map[row, col] = map[row - i, col];
                    }
                }

            }

            return rows.Count;
        }

        // 游戏结束检查
        private bool GameOverCheck()
        {
            return Collide(Move.STAY);
        }

        // 消除检查
        private List<int> ClearCheck()
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
        private void Clear(int row)
        {
            for (int col = 1; col <= Common.containerWidth; col++)
            {
                map[row, col] = -1;
            }
        }

        // 检测与其他方块的碰撞
        private bool Collide(Move move)
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
                    if (tetris.LeftCol() <= 0
                        || tetris.RightCol() >= Common.containerWidth + 1
                        || tetris.HighRow() <= 0
                        || tetris.LowRow() >= Common.containerHeight + 1)
                        return true;
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row, p.Col] >= 0)
                            return true;
                    }
                    return false;
                default: return true;
            }
        }

        // 将map上方块所在的原位置删除
        private void DeleteFromMap()
        {
            foreach (Point p in tetris.point)
            {
                map[p.Row, p.Col] = -1;
            }
        }

        // 在map上添加方块新位置
        private void AddToMap()
        {
            foreach (Point p in tetris.point)
            {
                map[p.Row, p.Col] = (int)tetris.Type;
            }
        }
    }
}



