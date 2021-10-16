using System;

namespace _04_03
{
    class Program
    {
        static void NODandNOK(uint a, uint b, out uint nod, out ulong nok)
        {
            uint i, j;
            i = a;
            j = b;
            while (i != j && i != 0 && j != 0)
            {
                if (j > i)
                    j %= i;
                else
                    i %= j;
            }
            if (j > i)
                nod = j;
            else
                nod = i;
            nok = a / nod * b;
        }
        static void Main(string[] args)
        {
            uint nod;ulong nok;
            Console.WriteLine("Введите первое число: ");
            uint a = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число: ");
            uint b = uint.Parse(Console.ReadLine());
            NODandNOK(a, b, out nod, out nok);
            Console.WriteLine($"НОД: {nod}, НОК: {nok}");
        }
    }
}
