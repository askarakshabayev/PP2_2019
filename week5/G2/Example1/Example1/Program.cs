using System;
using System.IO;

namespace Example1
{
    class Program
    {
        public static void F1()
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/askar/projects/PP2");
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            foreach (FileSystemInfo f in fs)
            {
                if (f.GetType() == typeof(FileInfo))
                {
                    Console.WriteLine(f.Name);
                }
                else
                {
                    DirectoryInfo dir = new DirectoryInfo(f.FullName);
                    //int size = 0;
                    //foreach(FileSystemInfo t in dir.GetFileSystemInfos())
                    //{
                    //    size++;
                    //}
                    int size = dir.GetFileSystemInfos().Length;
                    Console.WriteLine(f.Name + "(" + size + ")");
                }
            }
        }

        public static void F2() 
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/askar/projects/PP2");
            FileInfo[] files = directory.GetFiles("*.txt");
            Console.WriteLine(files.Length);
            foreach(FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }
        }

        public static bool IsPalin(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n / 2; i++)
                if (s[i] != s[n - i - 1])
                    return false;
            return true;
        }

        public static void F3()
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/askar/projects/PP2");
            foreach(FileSystemInfo fs in directory.GetFileSystemInfos())
            {
                if (IsPalin(fs.Name))
                {
                    Console.WriteLine(fs.Name);
                }
            }
        }

        public static void F4()
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/askar/projects/PP2");
            foreach (FileInfo file in directory.GetFiles())
            {
                Console.WriteLine(file.Name + " " + file.Length);
            }
        }

        public static void F5()
        {

        }

        static void Main(string[] args)
        {
            F4();
        }
    }
}
