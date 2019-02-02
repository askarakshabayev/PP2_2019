using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Enter amount of cents to open door");
            String s = Console.ReadLine();
            game.OpenDoorClick1 = int.Parse(s);
            Console.WriteLine("Enter amount of clicks to change door");
            s = Console.ReadLine();
            game.OpenDoorClick2 = int.Parse(s);
            while (!game.gameOver)
            {
                game.ShowMenu();
                s = Console.ReadLine();
                game.currentDoor = int.Parse(s);
            }

        }
    }
}
