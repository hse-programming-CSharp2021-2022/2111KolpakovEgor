using System;
using System.Linq;

namespace _14_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(-1000, 1001);

            Console.WriteLine("---------------------");

            Console.WriteLine("Начальная коллекция");
            foreach (int i in arr)
                Console.Write(i + " ");

            Console.WriteLine("\n" + "---------------------");

            var square_arr1 = arr.Select(x => x * x);
            var square_arr2 = from a in arr
                              select a * a;
            
            Console.WriteLine("Квадраты:");

            foreach (var square in square_arr1)
                Console.Write(square + " ");

            foreach (var square in square_arr2)
                Console.Write(square + " ");

            Console.WriteLine("\n" + "---------------------");

            var task2_1 = arr.Where(x => x > 0 && x.ToString().Length == 2);
            var task2_2 = from a in arr
                          where a > 0 && a.ToString().Length == 2
                          select a;

            Console.WriteLine("Положительные двузначные");

            foreach (var el in task2_1)
                Console.Write(el + " ");

            foreach (var el in task2_2)
                Console.Write(el + " ");

            Console.WriteLine("\n" + "---------------------");

            var task3_1 = arr.Where(x => x % 2 == 0).OrderByDescending(x => x);
            var task3_2 = from a in arr
                          where a % 2 == 0
                          orderby a descending
                          select a;

            Console.WriteLine("Чётные по убыванию");

            foreach (var el in task3_1)
                Console.Write(el + " ");

            foreach (var el in task3_2)
                Console.Write(el + " ");

            Console.WriteLine("\n" + "---------------------");

            var task4_1 = arr.Select(x => x).OrderByDescending(x => Math.Abs(x));
            var task4_2 = from a in arr
                          orderby Math.Abs(a) descending
                          select a;

            Console.WriteLine("Числа по порядку");

            foreach (var el in task4_1)
                Console.Write(el + " ");

            foreach (var el in task4_2)
                Console.Write(el + " ");

            Console.WriteLine("\n" + "---------------------");

        }
    }
}
