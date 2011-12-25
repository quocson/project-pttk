using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using TetrisReturn;

namespace TheClassicMapPlugin
{
    class TheClassicMap : Map
    {
        public TheClassicMap()
        {
            row = 26;
            col = 16;

            statusMap = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    statusMap[i, j] = 0;

            //xScreen = ?;
            //yScreen = ?;

            iMap = new Bitmap(TheClassicMapPlugin.Properties.Resources.ClassicMap);
        }

        //override method reset.
        public override void reset()
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    statusMap[i, j] = 0;
        }
    }
}
