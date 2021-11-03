using System;

namespace _02_01
{
    class MyComplex
    {
        public double re { get; set; }
        public double im { get; set; }
        public MyComplex(double xre, double xim)
        { re = xre; im = xim; }
        public static MyComplex operator ++(MyComplex mc)
        { mc.re++; mc.im++; return new MyComplex(mc.re + 1, mc.im + 1); }
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.re - 1, mc.im - 1); }
        public double Mod() { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re + b.re, a.im + b.im);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re - b.re, a.im - b.im);
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re*b.re - a.im * b.im, a.re*b.im + b.re* a.im);
        }
        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re * b.re + a.im * b.im / b.re * b.re + b.im * b.im, a.im * b.re - a.re * b.im / b.re * b.re + b.im * b.im);
        }
        public override string ToString()
        {
            return re + " " + im;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex a = new MyComplex(3, 2);
            MyComplex b = new MyComplex(4, 5);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a++);
        }
    }
}
