using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TetrisGame
{
    class GameController
    {
        public int[,] map;      // 点阵地图
        private Tetris tetris;  // 正在下落的方块


        private Timer timer;    // 方块下落计时器
        private int level;
        private int score;
        private int speedMaxLevel = 10;
        private int speedInterval = 100;
        private Random random = new Random();


        //public Container container { get; private set; }  // 容器
        public event Action OnNext;                       // 下一个方块事件
        public event Action OnPropertyChanged;            // 等级、分数改变事件
        public event Action OnGameOver;                   // 游戏结束事件

        // 难度等级
        public int Level
        {
            get { return level; }
            private set
            {
                level = value;
                OnPropertyChanged();
            }
        }
        // 分数
        public int Score
        {
            get { return score; }
            private set
            {
                score = value;
                OnPropertyChanged();
            }
        }
        // 下一个方块类型
        public Type NextType { get; private set; }

        // 构造方法
        public GameController()
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



        // 游戏开始
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
        // 游戏结束
        public void GameOver()
        {
            timer.Stop();
            timer.Close();
        }
        // 游戏暂停
        public void Pause()
        {
            timer.Stop();
        }
        // 游戏继续
        public void Continue()
        {
            timer.Start();
        }

        // 旋转
        public void Rotate()
        {
            Point[] pTemp = new Point[4]
            {
                new Point(tetris.point[0]),
                new Point(tetris.point[1]),
                new Point(tetris.point[2]),
                new Point(tetris.point[3]),
            };

            DeleteFromMap();

            tetris.Rotate();

            if (Collide(Move.STAY))
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
                return ClearUpMap();
            }

            DeleteFromMap();

            tetris.GoDown();

            AddToMap();

            return -1;
        }
        // 直接下落
        public void GoDownDirectly()
        {
            timer.Stop();



            DeleteFromMap();

            while (!Collide(Move.DOWN))
                tetris.GoDown();

            AddToMap();

            int clearRows = ClearUpMap();

            
            ScoreWhenClear(clearRows);
            timer.Start();
        }






        // 创建新方块
        private void NewTetris()
        {
            if (Create(NextType) == false)
            {
                OnGameOver();   // 无法创建新方块时时游戏结束
                return;
            }
            NextType = (Type)random.Next(Common.typeCount);
            OnNext();
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
        // 创建
        private bool Create(Type type)
        {
            tetris = new Tetris(type);
            int col = (Common.containerWidth - tetris.RightCol() + tetris.LeftCol() - 1) / 2;
            tetris.Move(new Point(0, col));

            if (Collide(Move.STAY))   // 无法再新建方块时游戏结束
                return false;


            AddToMap();

            return true;
        }

        // 方块下落计时器处理
        private void TimerUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            int clearRows = GoDown();
            ScoreWhenClear(clearRows);
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

        // 消行后整理地图
        private int ClearUpMap()
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
                while (rows.Contains(row - i))
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

        // 消除方块时的加分、加速
        private void ScoreWhenClear(int clearRows)
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

    }
}
