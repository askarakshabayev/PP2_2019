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