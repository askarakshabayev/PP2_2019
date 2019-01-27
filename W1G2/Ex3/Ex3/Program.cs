using System;

namespace Ex3
{
    class Program
    {   
        // "1,2,4,12"
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] arr = a.Split(",");
            int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += int.Parse(arr[i]);
            //}
            foreach (string s in arr)
            {
                sum += int.Parse(s);
            }
            Console.WriteLine(sum);
        }
    }
}
