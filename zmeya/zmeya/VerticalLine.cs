using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeya
{
    class VerticalLine
    {
        List<Point> VStena;

        public VerticalLine(int yTop, int yDown, int x, char sym)
        {
            VStena = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                VStena.Add(p);
            }
                          
        }
        public void Drow()
        {
            foreach (Point p in VStena)
            {
                p.Draw();
            }
        }
        
    }
}
