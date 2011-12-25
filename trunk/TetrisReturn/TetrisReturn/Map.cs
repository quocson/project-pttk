﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TetrisReturn
{
    public class Map : IDisposable
    {
        protected int[,] statusMap;//status of blocks on the map.

        protected Bitmap iMap;//image of map

        protected int row;//row of map.
        protected int col;//colum of map.

        protected int xScreen;//x position of shape on the screen.
        protected int yScreen;//y position of shape on the screen.

        public Map()
        {
        }

        public void Dispose()
        {
            iMap.Dispose();
            GC.SuppressFinalize(this);
        }

        //Status Map properties.
        public int[,] StatusMap
        {
            get { return statusMap; }
            set { statusMap = value; }
        }

        //check point on map.
        public bool checkOnMap(int x, int y)
        {
            //if
            return false;
        }

        //check overflow map.
        public bool checkOverflow()
        {
            //if
            return false;
        }

        //reset the map.
        public virtual void reset()
        {
        }

        //update the map.
        public void update()
        {
        }
    }
}
