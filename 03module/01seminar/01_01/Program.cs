using System;

namespace _01_01
{
    class Program
    {
        delegate int Cast(double val);
        public static int M1(double x)
        {
            return (int)(x / 2) * 2;
        }
        public static int M2(double x)
        {
            return (int)(Math.Log10(x)) + 1;
        }
        static void Main(string[] args)
        {
            Cast cast1 = delegate (double x)
            {
                return (int)(x / 2) * 2;
            };
            Cast cast2 = (x) => (int)(Math.Log10(x)) + 1;
            Console.WriteLine(cast1(11.7)); 
            Console.WriteLine(cast2(110.7)); 
            Cast cast3 = cast1 + cast2;
            Console.WriteLine();
            Console.WriteLine(cast3?.Invoke(110.7));
            cast3 -= (x) => (int)(Math.Log10(x)) + 1;
            Console.WriteLine(cast3?.Invoke(110.7));
        }
    }
}
