using System;

namespace _02_03
{
    class Program
    {
        static void CalculateRoots(int a, int b, int c, out int amount, out double x1, out double x2)
        {
            double Discr;
            Discr = b * b - 4 * a * c;
            amount = Discr >= 0 ? (Discr > 0 ? 2 : 1) : 0;
            x1 = amount > 0 ? ((-b + Math.Sqrt(Discr)) / (2 * a)) : 0; 
            x2 = amount > 1 ? ((-b - Math.Sqrt(Discr)) / (2 * a)) : 0;

        }
        static void Main(string[] args)
        {
            int k; double x1, x2;
            Console.WriteLine("Введите коэффицент a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент c:");
            int c = int.Parse(Console.ReadLine());
            CalculateRoots(a, b, c, out k, out x1, out x2);
            Console.WriteLine($"Кол-во действительных корней: {k}");
            string res = (k > 0 ? (k > 1 ? $"Корни: {x1}, {x2}\n" : $"Корень: {x1:F3}\n") : "");
            Console.Write(res);
        }
    }
}
