using System;

namespace _05_03
{
    class Program
    {
        public static void Print(int[] arr)
        {
            foreach (var el in arr)
                Console.Write($"{el}  ");
        }
        public static int[] ArrCreator(int n, int a, int d)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = a + i * d;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите D: ");
            int d = int.Parse(Console.ReadLine());
            int[] arr = ArrCreator(n, a, d);
            Print(arr);
        }
    }
}
