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
            Point p1 = new Point(10,11, '*');
            p1.Draw();
            
            Point p2 = new Point(15,19, '#');           
            p2.Draw();

            HorisontalLine Stena1 = new HorisontalLine(10,25,12,'—');
            Stena1.Drow();

            VerticalLine Stena2 = new VerticalLine(10, 18, 12, '|');
            Stena2.Drow();


            Console.ReadLine();
            
            

        }


    }
}
