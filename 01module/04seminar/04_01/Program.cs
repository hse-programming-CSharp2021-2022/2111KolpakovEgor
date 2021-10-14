using System;
namespace ConsoleApp5
{
    class Program
    {
        static double Total(double k, double r, uint n)
        {
            return Math.Pow((1 + r), n) * k;
        }
        static void Main(string[] args)
        {
            double k = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine(Total(k, r, n));
            }
        }
    }
}
