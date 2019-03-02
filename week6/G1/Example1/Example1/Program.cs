using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int x = 10, y = 10;
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    x--;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    x++;

                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                keyInfo = Console.ReadKey();
            }
        }
    }
}
