using System;

namespace _03_01
{
    class Program
    {
        class ArithmeticProgression
        {
            public int A0 { get; set; }
            public int D { get; set; }
            public ArithmeticProgression(int a, int d)
            {
                A0 = a; D = d;
            }
            public int this[int i]
            {
                get
                {
                    return A0 + i * D;
                }
            }
        }
        static void Main(string[] args)
        {
            ArithmeticProgression progression = new ArithmeticProgression(1, 5);
            Console.WriteLine(progression[0]);
            Console.WriteLine(progression[1]);
            Console.WriteLine(progression[5]);
        }
    }
}
