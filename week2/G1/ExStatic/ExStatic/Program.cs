using System;

namespace ExStatic
{

    class Test
    {
        public static int a;
        public int b;

        public void incA()
        {
            a++;
        }

        public void incB()
        {
            b++;
        }

        public void print()
        {
            Console.WriteLine(a + " " + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test c = new Test();
            Test d = new Test();

            c.incA();
            d.incA();
            c.incB();
            d.incB();
            Test.a++;

            c.print();
            d.print();
            // 1 0 
            // 1 0
        }
    }
}
