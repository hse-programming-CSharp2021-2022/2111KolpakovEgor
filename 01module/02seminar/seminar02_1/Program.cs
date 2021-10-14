using System;

namespace seminar02_1
{
    class Program
    {
        public static void Replace(int x, int y, int z)
        {
            Console.WriteLine(x >= z ? x >= y ? x : y : z);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите z:");
            int z = int.Parse(Console.ReadLine());
            Console.Write("Наибольшее значение: ");
            Replace(x, y, z);
        }
    }
}
