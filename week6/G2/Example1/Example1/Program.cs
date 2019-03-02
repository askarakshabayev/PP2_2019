using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool isAlive = true;
            int x = 10;
            int y = 10;
            while (isAlive)
            {
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                Console.Clear();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    y--;
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    y++;
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                    x--;
                if (consoleKey.Key == ConsoleKey.RightArrow)
                    x++;
                if (consoleKey.Key == ConsoleKey.Escape)
                    break;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
            }
        }
    }
}
