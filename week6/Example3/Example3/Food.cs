﻿using System;
namespace Example3
{
    public class Food:GameObject
    {
        public Food(int x, int y, char sign, ConsoleColor color):base(x, y, sign, color)
        {
        }

        public void Generate(Snake snake, Wall wall)
        {
            bool ok = true;
            while (ok)
            {
                Random random = new Random();
                body[0].x = random.Next(1, Console.WindowWidth);
                body[0].y = random.Next(1, Console.WindowHeight);
                ok = false;
                foreach(Point p in snake.body)
                {
                    if (p.x == body[0].x && p.y == body[0].y)
                        ok = true;
                }
                foreach (Point p in wall.body)
                {
                    if (p.x == body[0].x && p.y == body[0].y)
                        ok = true;
                }
            }


        }
    }
}
