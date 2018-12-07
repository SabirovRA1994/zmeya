using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,11, '*');
            p1.Draw();
            

            Point p2 = new Point(15,19, '#');           
            p2.Draw();

            List<int> Spisok = new List<int>();
            Spisok.Add(1);
            Spisok.Add(2);
            Spisok.Add(0);

            int x = Spisok[0];
            int y = Spisok[1];
            int z = Spisok[2];

            foreach (int i in Spisok)
            {
                Console.WriteLine(i);

            }

            Spisok.RemoveAt(0);

            List<Point> SpisokPoint = new List<Point>();
            {
                SpisokPoint.Add(p1);
                SpisokPoint.Add(p2);

            }

        
            
            Console.ReadLine();
            
            

        }


    }
}
