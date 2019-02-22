using System;
using System.IO;

namespace Example1
{
    class Program
    {
        public static void F1()
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/askar/projects/PP2");
            FileSystemInfo[] fs = dir.GetFileSystemInfos();
            foreach(FileSystemInfo f in fs)
            {
                if (f.GetType() == typeof(FileInfo))
                    Console.WriteLine(f.Name);
                else
                {
                    DirectoryInfo d1 = new DirectoryInfo(f.FullName);
                    Console.WriteLine(f.Name + "(" + d1.GetFileSystemInfos().Length + ")");
                }
            }
        }

        public static void F2()
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/askar/projects/PP2");
            FileInfo[] files = dir.GetFiles("*.txt");
            Console.WriteLine(files.Length);
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
            DirectoryInfo dir = new DirectoryInfo("/Users/askar/projects/PP2");
            foreach (FileSystemInfo fs in dir.GetFileSystemInfos())
            {
                if (IsPalin(fs.Name))
                {
                    Console.WriteLine(fs.Name);
                }
            }
        }
        static void Main(string[] args)
        {
            F3();
        }
    }
}
