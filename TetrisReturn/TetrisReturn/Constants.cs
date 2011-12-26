using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapPluginInterface;

namespace TetrisReturn
{
    public static class Constants
    {
        public const int blockSize = 30;//size of block.
        public static Random r = new Random(unchecked((int)DateTime.Now.Ticks));//static variable random.
        public static Map map = new Map();//static map of game.
        public static PluginMapServices mapService = new PluginMapServices();//static plugin map services.

        //set type for the static map.
        public static void setType(Map m)
        {
            map = m;
        }
    }
}
