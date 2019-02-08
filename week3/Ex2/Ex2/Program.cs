using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                int y = 0;
                while (true)
                {
                    try
                    {
                        ConsoleKeyInfo consoleKey = Console.ReadKey();
                    }catch(Exception e)
                    {

                    }
                    if (consoleKey.Key == ConsoleKey.UpArrow)
                        y--;
                    if (consoleKey.Key == ConsoleKey.DownArrow)
                        y++;
                    if (consoleKey.Key == ConsoleKey.RightArrow)
                        x++;
                    if (consoleKey.Key == ConsoleKey.LeftArrow)
                        x--;
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
