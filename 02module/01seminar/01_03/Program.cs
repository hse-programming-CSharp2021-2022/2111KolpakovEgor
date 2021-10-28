using System;

namespace _01_03
{
    class RegularPoligons
    {
        int parties; double r;
        public double P
        {
            get
            {
                double R = r / Math.Cos(180 / parties);
                double a = Math.Abs(2 * R * Math.Sin(180 / parties));
                return parties * a;
            }
        }
        public double S
        {
            get
            {
                return 0.5 * P * r;
            }
        }
        public RegularPoligons(int parties = 0, double r = 0)
        {
            this.parties = parties; this.r = r;
        }
        public string PoligonData()
        {
            return "Parties = " + parties + "\n" + "r = " + r + "\n" + "P = " + P + "\n" + "S = " + S;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во объектов:");
            int n = int.Parse(Console.ReadLine());
            RegularPoligons[] arr = new RegularPoligons[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Объект {i+1}: ");
                Console.WriteLine("Введите кол-во сторон:");
                int parties = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите радиус вписанной окружности:");
                double r = double.Parse(Console.ReadLine());
                arr[i] = new RegularPoligons(parties, r);
            }
            double maxS = 0, minS = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i].S > arr[i + 1].S)
                    maxS = arr[i].S;
                else
                    maxS = arr[i + 1].S;
                if (arr[i].S < arr[i + 1].S)
                    minS = arr[i].S;
                else
                    minS = arr[i + 1].S;
            }
            foreach (var k in arr)
            {
                if (k.S == minS)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(k.PoligonData());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (k.S == maxS)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(k.PoligonData());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.WriteLine(k.PoligonData());
            }
        }
    }
}
