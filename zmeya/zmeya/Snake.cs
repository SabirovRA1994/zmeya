using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeya
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Point tall, int Leight, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i <= Leight; i++)
            {
                Point p = new Point(tall);
                p.Move(i, direction);
                pList.Add(p);
            }
            
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;

        }

        public void Uprav(ConsoleKey Key)
        {
            if (Key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (Key == ConsoleKey.RightArrow)
                direction = Direction.Rigth;
            else if (Key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            else if (Key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }
    }


}
