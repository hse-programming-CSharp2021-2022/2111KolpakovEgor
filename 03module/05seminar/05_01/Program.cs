using System;

namespace _05_01
{
    interface IFunction
    {
        public double Function(double x);
    }
    public delegate double Calculate(double x);

    class F: IFunction
    {
        Calculate calculate;
        public F(Calculate calculate) => this.calculate = calculate;
        public double Function(double x) => calculate(x);
    }

    class G
    {
        F first, second;

        public G(F first, F second)
        {
            this.first = first;
            this.second = second;
        }

        public double GF(double x0) => first.Function(second.Function(x0));

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            G g = new G(new F(x => x * x - 4), new F(x => Math.Sin(x)));

            for (double i = 0; i < Math.PI; i += Math.PI / 16)
                Console.WriteLine($"{Math.Round(i,4)} = " + Math.Round(g.GF(i),4));
        }
    }
}
