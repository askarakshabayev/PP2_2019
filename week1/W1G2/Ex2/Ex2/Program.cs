using System;

namespace Ex2
{
    class Program
    {
        // 4 5 6
        static void Main(string[] args)
        {
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //int a = int.Parse(s1);
            //int b = int.Parse(s2);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            Console.WriteLine(a + b);

        }
    }
}
