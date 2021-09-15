using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    class Container
    {
        int[,] map;
        Tetris tetris;
        State tetrisState;
        public Container()
        {
            map = new int[Common.conatinerHeight,Common.conatinerWidth];
            tetris = null;
        }


        public void Create(Type type)
        {
            
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
                        if (map[p.Row, p.Col - 1] > 0)
                            return true;
                    }
                    return false;
                case Move.RIGHT:
                    if (tetris.RightCol() >= Common.conatinerWidth)
                        return true;
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row, p.Col + 1] > 0)
                            return true;
                    }
                    return false;
                case Move.DOWN:
                    if (tetris.LowRow() >= Common.conatinerHeight)
                        return true;
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row + 1, p.Col] > 0)
                            return true;
                    }
                    return false;
                case Move.STAY:
                    foreach (Point p in tetris.point)
                    {
                        if (map[p.Row, p.Col] > 0)
                            return true;
                    }
                    return false;
                default: return true;
            }
        }


        // 左移
        public void GoLeft()
        {
            if (Collide(Move.LEFT))
                return;
            tetris.GoLeft();
        }
        // 右移
        public void GoRight()
        {
            if (Collide(Move.RIGHT))
                return;
            tetris.GoRight();
        }
        // 下落
        public void GoDown()
        {
            if (Collide(Move.DOWN))
            {
                DropOnGround();
                return;
            }
            tetris.GoDown();
        }
        // 直接下落
        public void GoDownDirectly()
        {
            while(!Collide(Move.DOWN))
                tetris.GoDown();

            DropOnGround();
        }
        // 落地
        public void DropOnGround()
        {
            
        }
    }
}



