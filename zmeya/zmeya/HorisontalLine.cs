using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeya
{
    class HorisontalLine
    {
        List<Point> HStena;

        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            HStena = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                HStena.Add(p);
            }
                          
        }
        public void Drow()
        {
            foreach (Point p in HStena)
            {
                p.Draw();
            }
        }
        
    }
}
