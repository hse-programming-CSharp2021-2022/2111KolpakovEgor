using System;

namespace ConsoleApp4
{
    class Program
    {
        public static int r = 2;
        static int angleStart = -90; static int angleEnd = 45;
        public static bool Mymethod(int x, int y)
        {
            double p = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double angle = Math.Atan(y / x);
            if (p <= r && angle >= angleStart && angle <= angleEnd)
            {
                return true;
            }
            return false;

        }
        public static double Function1(double x, double y)
        {
            if (x < y && x > 0)
                return x + Math.Sin(y);
            else if (x > y && x < 0)
                return y - Math.Cos(x);
            else
                return 0.5 * x * y;
        }
        public static double Function2(double x)
        {
            if (x <= 0.5)
                return Math.Sin(Math.PI / 2);
            else
                return Math.Sin((Math.PI * (x - 1)) / 2);
        }
        public static int SameFloor(int x1, int x2, int x3)
        {
            if (x1 / 100 == x2 / 100 && x2 / 100 == x3 / 100)
                return 1;
            else if (x1 / 100 == x2 / 100 && x2 / 100 != x3 / 100)
                return 2;
            else if (x1 / 100 == x3 / 100 && x3 / 100 != x2 / 100)
                return 3;
            else if (x2 / 100 == x3 / 100 && x3 / 100 != x1 / 100)
                return 4;
            else
                return 5;
        }
        public static void Floor(int class1, int class2, int class3)
        {

            if (SameFloor(class1, class2, class3) == 1)
            {
                Console.WriteLine("Этаж" + class1 / 100 + ": " + Math.Min(class3, Math.Min(class1, class2)));
            }
            else if (SameFloor(class1, class2, class3) == 2)
            {
                Console.WriteLine("Этаж" + class1 / 100 + ": " + Math.Min(class1, class2));
                Console.WriteLine("Этаж" + class3 / 100 + ": " + class3);

            }
            else if (SameFloor(class1, class2, class3) == 3)
            {
                Console.WriteLine("Этаж" + class1 / 100 + ": " + Math.Min(class1, class3));
                Console.WriteLine("Этаж" + class2 / 100 + ": " + class2);
            }
            else if (SameFloor(class1, class2, class3) == 4)
            {
                Console.WriteLine("Этаж" + class2 / 100 + ": " + Math.Min(class2, class3));
                Console.WriteLine("Этаж" + class1 / 100 + ": " + class1);
            }
            else
            {
                Console.WriteLine("Этаж" + class1 / 100 + ": " + class1);
                Console.WriteLine("Этаж" + class2 / 100 + ": " + class2);
                Console.WriteLine("Этаж" + class3 / 100 + ": " + class3);

            }
        }
        static void Main(string[] args)
        {
            Floor(301, 402, 503);
        }
    }
}

