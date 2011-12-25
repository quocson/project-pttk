using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using TetrisReturn;

namespace TheDeathSawMapPlugin
{
    class TheDeathSawMap : Map
    {
        public TheDeathSawMap()
        {
            statusMap = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if((i % 2 == 0) && (j == 0 || j == 1))
                        statusMap[i, j] = -2;
                    else
                        statusMap[i, j] = -1;

            iMap = new Bitmap(TheDeathSawMapPlugin.Properties.Resources.DeathSawMap);
        }

        //override method reset.
        public override void reset()
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if ((i % 2 == 0) && (j == 0 || j == 1))
                        statusMap[i, j] = -2;
                    else
                        statusMap[i, j] = -1;
        }
    }
}
