using System;

namespace _05_04
{
    class Program
    {
        public static int[,] CreateMatrix(int m, int n)
        {
            int[,] arr = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = rnd.Next(1, 10);
            return arr;
        }
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static int Sum(int[,]arr, int k)
        {
            int res = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                res += arr[k + 1,i];
            return res;
        }
        public static int Pr(int[,] arr, int k)
        {
            int res = 1;
            for (int i = 0; i < arr.GetLength(1); i++)
                res *= arr[k + 1, i];
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк матрицы: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов матрицы: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер строки, в которой вы хотите посчитать сумму и произведение элементов: ");
            int k = int.Parse(Console.ReadLine());
            int[,] arr = CreateMatrix(m, n);
            Console.WriteLine("Ваша матрица: ");
            Print(arr);
            Console.Write("Cумма: ");
            Console.WriteLine(Sum(arr, k));
            Console.Write("Произведение: ");
            Console.Write(Pr(arr, k));
        }
    }
}
