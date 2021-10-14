using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa = 0;
            double new_s;
            double k = 2;
            double p;
            do
            {
                new_s = summa;
                p = 1 / ((k - 1) * (k) * (k + 1));
                summa += p;
                k++;
            } while (new_s != summa);
            Console.WriteLine("double: " + summa);
            float summa2 = 0;
            float k2 = 2;
            float pn, new_s2;
            do
            {
                new_s2 = summa2;
                pn = 1 / ((k2 - 1) * (k2) * (k2 + 1));
                summa2 += pn;
                k2++;
            } while (summa2 != new_s2);
            Console.WriteLine("float: " + summa2);

        }
    }
}