using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zmeya
{
    class Program
    {
        static void Main(string[] args)
        {        
            HorisontalLine StenaUp = new HorisontalLine(1,100,1,'—');
            HorisontalLine StenaDown = new HorisontalLine(1,100,25, '—');
            StenaUp.Drow();
            StenaDown.Drow();
            VerticalLine StenaLeft = new VerticalLine(1,25,1, '|');
            VerticalLine StenaRigth = new VerticalLine(1,25,100, '|');
            StenaLeft.Drow();
            StenaRigth.Drow();

            Point p = new Point(50, 11, '*');
            Snake snake = new Snake(p, 5, Direction.Rigth);
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Uprav(key.Key);
                }
                if ((snake.direction == Direction.Up) || (snake.direction == Direction.Down) )
                {
                    Thread.Sleep(200);
                }
                else {
                    Thread.Sleep(100);
                }

                snake.Move();

            }

            snake.Move();
            
            Thread.Sleep(300);



            Console.ReadLine();
            
            

        }


    }
}
