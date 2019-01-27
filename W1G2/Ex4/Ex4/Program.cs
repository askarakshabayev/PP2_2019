using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // "x1,y1 x2,y2"
            // [0] = "x1,y1"
            // [1] = "x2,y2"
            string s = Console.ReadLine();
            string[] arr = s.Split();
            string[] a = arr[0].Split(","); // [0] = x1, [1] = y1
            string[] b = arr[1].Split(","); // [0] = x2, [1] = y2
            if (a[0] == b[0] || a[1] == b[1])
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
