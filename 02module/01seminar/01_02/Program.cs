using System;

namespace _01_02
{
    class RegularPoligons
    {
        int parties; double r;
        public double P
        {
            get
            {
                double R = r / Math.Cos(180 / parties);
                double a = 2 * R * Math.Sin(180 / parties);
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
            return "Parties = " + parties +"\n" + "r = " + r + "\n" + "P = " + P + "\n" + "S = " + S; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RegularPoligons a = new RegularPoligons(5, 3);
            Console.WriteLine(a.PoligonData());
        }
    }
}
