using System;

namespace Example2
{
    class Complex
    {
        int a, b;

        public Complex(int a_, int b_)
        {
            a = a_;
            b = b_;
        }
        public Complex() { }

        public void Read()
        {
            String[] s = Console.ReadLine().Split("/"); // 1/2
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
            c3.b = c1.b * c2.b;
            c3.a = c1.a * c2.b + c1.b * c2.a;
            return c3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.Read();
            c2.Read();
            Complex c3 = c1 + c2;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("c1 + c2 = " + c3);
        }
    }
}
