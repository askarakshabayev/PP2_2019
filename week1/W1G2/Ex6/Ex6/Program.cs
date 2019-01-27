using System;
using System.Collections.Generic;

namespace Ex6
{
    class Program
    {
        static void F1()
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
                a[i] = i * i;

            foreach (int k in a)
            {
                Console.WriteLine(k);
            }
        }

        static void F2()
        {
            int[,] a = new int[10, 10];

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    a[i, j] = i * j;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void F3()
        {
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(12);
            list.Add(6);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

        }

        static void F4()
        {
            int[] a = { 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
        }

        static void F5()
        {
            int[,] a = { 
                { 1, 1, 1 }, 
                { 2, 2, 2 }, 
                { 3, 3, 3 } 
            };
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++)
                    Console.Write(a[i, j]);
                Console.WriteLine();
            }
        }
        static void F6()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                for (int j = 0; j < m; j++) {
                    a[i, j] = int.Parse(arr[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            F6();
        }
    }
}
