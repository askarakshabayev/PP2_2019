using System;
namespace Game
{
    public class Game
    {
        public bool gameOver = false;
        public int OpenDoorClick1;
        public int OpenDoorClick2;
        public int currentDoor;

        public int door1min_amount;
        public int door1max_amount;

        public Game()
        {
            OpenDoorClick1 = 0;
            OpenDoorClick2 = 0;
            currentDoor = 0;

            door1min_amount = 1;
            door1max_amount = 10;


        }
        public void ShowMenu()
        {
            Console.Clear();
            if (currentDoor == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Red door opened");
            } else {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Red door");
            }

            if (currentDoor == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("2. Blue door opened");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("2. Blue door");
            }
            if (currentDoor == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3. Green door opened");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("3. Green door");
            }
            Console.SetCursorPosition(100, 100);
            Console.WriteLine("200");
        }
    }
}
