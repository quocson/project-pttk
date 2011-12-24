using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TetrisReturn
{
    public static class Constants
    {
        public const int blockSize = 30;// size of block.
        public static Random r = new Random(unchecked((int)DateTime.Now.Ticks));// static variable random.
        public static Map map = new Map();// static map of game.

        //set type for the static map.
        public static void setType(Map m)
        {
            map = m;
        }
    }
}
