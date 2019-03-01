using System;
using System.Collections.Generic;
namespace Example3
{
    public class GameObject
    {
        public List<Point> body;
        public char sign;
        ConsoleColor color;

        public GameObject() { }
        public GameObject(int x, int y, char sign, ConsoleColor color)
        {
            body = new List<Point>();
            body.Add(new Point(x, y));
            this.sign = sign;
            this.color = color;
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
