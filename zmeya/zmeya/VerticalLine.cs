﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeya
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yDown, int x, char sym)
        {
            Stena = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                Stena.Add(p);
            }
                          
        }
        
        
    }
}