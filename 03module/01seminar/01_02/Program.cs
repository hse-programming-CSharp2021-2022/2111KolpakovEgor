using System;

namespace _01_02
{
    class Program
    {
        delegate double DelegateConvertTemperature(double x);
        static void Main(string[] args)
        {
            TemperatureConverterlmp t = new();
            DelegateConvertTemperature d1 = t.CtoF;
            DelegateConvertTemperature d2 = t.FtoC;

            Console.WriteLine(d1(25.8));
            Console.WriteLine(d2(78.44));
        }
    }
    class TemperatureConverterlmp
    {
        public double CtoF(double c) => 9 * c / 5 + 32;
        public double FtoC(double f) => 5 * (f - 32) / 9;
    }
}
