using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeya
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(50,11, '*');
            p1.Draw();
            
            Point p2 = new Point(15,19, '#');           
            p2.Draw();

            HorisontalLine StenaUp = new HorisontalLine(10,110,2,'—');
            HorisontalLine StenaDown = new HorisontalLine(10,110,25, '—');
            StenaUp.Drow();
            StenaDown.Drow();
            VerticalLine StenaLeft = new VerticalLine(2,25,10, '|');
            VerticalLine StenaRigth = new VerticalLine(2,25,110, '|');
            StenaLeft.Drow();
            StenaRigth.Drow();


            Console.ReadLine();
            
            

        }


    }
}
