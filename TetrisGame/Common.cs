using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    enum Type { I, O, T, J, L, S, Z }; // 方块的类型，分别为：长条形、正方形、T型、J型、L型、S型、Z型
    enum Move { LEFT, RIGHT, DOWN, STAY }; // 移动方向

    enum GameState { Start, Pause, Stop };  // 游戏进行状态

    //enum TestColor { Cyan, Yellow, Purple, Blue, Orange, Green, Red };  // 依次表示IOTJLSZ的颜色



    // 游戏基本属性
    class Common
    {
        public static int containerHeight = 20;   // 容器格子数
        public static int containerWidth = 10;
        public static int nextPanelHeight = 4;    // 下一个方块窗口格子数
        public static int nextPanelWidth = 4;


        public static int typeCount = 7;      // 枚举类型个数
        public static int moveCount = 4;
        public static int gameStateCount = 3;
        //public static int ColorCount = 7;
    }
}
