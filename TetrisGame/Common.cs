using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    enum Type { I, O, T, J, L, S, Z }; // 方块的类型，分别为：长条形、正方形、T型、J型、L型、S型、Z型

    enum Move { LEFT, RIGHT, DOWN, STAY }; // 移动方向

    enum State { Created, Dropping, Dropped };

    enum Color { Cyan, Yellow, Purple, Blue, Orange, Green, Red };  // 依次表示IOTJLSZ的颜色


    class Common
    {
        public static int conatinerHeight = 20;
        public static int conatinerWidth = 10;
    }
}
