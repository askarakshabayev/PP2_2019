﻿using System;
using System.Collections.Generic;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Rectangle rectangle = new Rectangle(4, 5);
            Circle circle = new Circle(1, 2, 3);

            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach(Shape shape in shapes)
            {
                if (shape.GetType() == typeof(Circle))
                {
                    Console.WriteLine(((Circle)shape).x + " " + ((Circle)shape).y + " " + ((Circle)shape).r);
                }
                else
                {
                    Console.WriteLine(shape.x + " " + shape.y);
                }
            }

            //Console.WriteLine(rectangle.x + " " + rectangle.y);
            //Console.WriteLine(circle.x + " " + circle.y + " " + circle.r);

        }
    }
}
