using System;

namespace _02_01
{
    public delegate int Caste(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Caste caste1 = delegate (double x)
            {
                return (int)x / 2 * 2;
            };

            Caste caste2 = (x) => (int)Math.Log10(x) + 1;

            Console.WriteLine(caste1.Invoke(33.3));
            Console.WriteLine(caste2.Invoke(245.7));

            Caste caste3 = caste1 + caste2;
            Console.WriteLine(caste3.Invoke(33.3));

            caste3 -= caste2;
            Console.WriteLine(caste3.Invoke(33.3));

            caste3 += caste2;
            caste3 -= x => (int)Math.Log10(x) + 1;
            Console.WriteLine(caste3.Invoke(33.3));
        }
    }
}
