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

        public override string ToString()
        {
            return a + " " + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();
            t1.incA();
            t2.incA();
            t1.incB();
            t2.incB();
            Test.a++;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
