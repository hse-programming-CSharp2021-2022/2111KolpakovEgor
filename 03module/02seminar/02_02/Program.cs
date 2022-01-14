using System;

namespace _02_02
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, -9, 10, 33, 100, -6 };
            Action<int> action = (x) => Console.WriteLine($"{x} ");
            Array.ForEach(arr, action);
            Console.WriteLine();

            Converter<int, int> converter = (x) => 2 * x;
            int[] arr2 = Array.ConvertAll(arr, converter);
            Array.ForEach(arr2, action);
            Console.WriteLine();

            Predicate<int> predicate = (x) => x > 0;
            int[] arr3 = Array.FindAll(arr, predicate);
            Array.ForEach(arr3, action);
            Console.WriteLine();

            Console.WriteLine(Array.TrueForAll(arr, predicate));
            Console.WriteLine(Array.TrueForAll(arr3, predicate));
            Console.WriteLine();

            Comparison<int> comparison = (x, y) => x.CompareTo(y);
            // (x,y) => 1, 0, -1
            // 1 - порядок нарушен, надо менять местами
            // 0 - элементы одинаковые
            Array.Sort(arr, comparison);
            Array.ForEach(arr, action);
            Console.WriteLine();

            Func<int, double> d5 = (x) => x / 10.0;
            Console.WriteLine(d5(15));

            Func<int, int, bool> d6 = (x, y) => x > y;
            Console.WriteLine(d6(15, 10));


        }
    }
}
