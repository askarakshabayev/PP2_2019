using System;

namespace Ex10
{
    class Complex
    {
        int a, b;

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Complex Add(Complex c)
        {
            Complex c1 = new Complex(this.a + c.a, this.b + c.b);
            return c1;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.a + c2.a, c1.b + c2.b);
            return c;
        }

        //public static Complex operator +(Complex c1, int c2)
        //{
        //    Complex c = new Complex(c1.a + c2, c1.b + c2);
        //    return c;
        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2); // c1.a = 1, c1.b = 2
            Complex c2 = new Complex(2, 4); // c2.a = 2, c2.b = 4
            //Complex c = c1.Add(c2);
            Complex d = c1 + c2 + c1 + c2;
            // (1, 2) + 3 = (4, 5)
            // Complex d = c1 + 3;
            Console.WriteLine(d);

        }
    }
}
