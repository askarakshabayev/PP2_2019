using System;
using System.IO;

namespace Ex1
{
    class Program
    {
        static void Ex1()
        {
            FileInfo fileInfo = new FileInfo("/Users/askar/Desktop/logo.png");
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Directory);
        }

        static void Ex2()
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/askar/Desktop/");
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.WriteLine(directory.Parent);
        }

        static void Ex3()
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/askar/projects/PP2/week2/test1/");
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
        }

        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        static void Ex4(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Ex4(d, level + 1);
            }
        }

        public static void Ex5()
        {
            DirectoryInfo d = new DirectoryInfo("/Users/askar/projects/PP2/");
            FileSystemInfo[] fs = d.GetFileSystemInfos();
            foreach (FileSystemInfo f in fs)
            {
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.WriteLine("DIRECTORY: " + f.Name);
                }
                else
                {
                    Console.WriteLine("FILE: " + f.Name);
                }
            }
        }

        static void Ex6()
        {
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
        }

        static void Ex7()
        {
            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine("hello");
            sw.WriteLine("world");
            sw.Close();
        }

        static void Ex8()
        {
            ConsoleKeyInfo ck = Console.ReadKey();
            while (ck.Key != ConsoleKey.Escape)
            {
                if (ck.Key == ConsoleKey.UpArrow)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UpArrow");
                }
                if (ck.Key == ConsoleKey.DownArrow)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("DownArrow");
                }
                ck = Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("/Users/askar/projects/PP2");
            //Ex4(d, 0);
            Ex8();
        }
    }
}
