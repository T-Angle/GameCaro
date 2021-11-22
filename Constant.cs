using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Constant
    {
        public static int CHESS_WIDTH = 32;
        public static int CHESS_HEIGHT = 32;

        public static Size CHESS_BOARD = new Size(640, 640);
        public static Point CHESS_INIT_LOCATION =
            new Point(-CHESS_WIDTH, 0);
    }
}
