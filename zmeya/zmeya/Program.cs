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
            HorisontalLine StenaUp = new HorisontalLine(10,110,2,'—');
            HorisontalLine StenaDown = new HorisontalLine(10,110,25, '—');
            StenaUp.Drow();
            StenaDown.Drow();
            VerticalLine StenaLeft = new VerticalLine(2,25,10, '|');
            VerticalLine StenaRigth = new VerticalLine(2,25,110, '|');
            StenaLeft.Drow();
            StenaRigth.Drow();

            Point p = new Point(50, 11, '*');
            Snake snake = new Snake(p, 5, Direction.Rigth);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);



            Console.ReadLine();
            
            

        }


    }
}
