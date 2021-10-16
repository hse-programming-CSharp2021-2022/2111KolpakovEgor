using System;

namespace _03_04
{
    class Program
    {
        static bool Triangle(double x, double y, double z, out double p, out double s)
        {
            if (x + y <= z || z + y <= x || z + x <= y)
            {
                p = 0; s = 0;
                return false;
            }
            p = x + z + y;
            double p2 = p / 2;
            s = Math.Sqrt(p2* (p2 - x) * (p2 - y) * (p2 - z));
            return true;
        }
            static void Main(string[] args)
        {
            double s, p;
            Console.WriteLine("Введите a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c:");
            int c = int.Parse(Console.ReadLine());
            if (Triangle(a, b, c, out p, out s))
            {
                Console.WriteLine($"Периметр треугольника: {p}" + "\n" + $"Площадь треугольника: {s}");
            }
            else
                Console.WriteLine("Треугольника не существует!");
        }
    }
}
