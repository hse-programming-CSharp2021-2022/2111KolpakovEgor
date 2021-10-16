using System;

namespace _02_04
{
    class Program
    {
        static void Polynom(double x, out double value)
        {
            value = x * (x * (x * (12 * x + 9) - 3) + 2) - 4;
        }

        static void Main(string[] args)
        {
            double res;
            Console.Write("Введите число: ");
            double x = double.Parse(Console.ReadLine());
            Polynom(x, out res);
            Console.WriteLine($"Polynom: {res}");
        }
    }
}
