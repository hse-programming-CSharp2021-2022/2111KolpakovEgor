using System;

namespace _05_01
{
    class Program
    {
        static public int[] AddMatrix(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(10, 51);
            return arr;
        }
        static public void PrintMatrix(int [] arr)
        {
            foreach (int a in arr)
                Console.Write(a + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrC = new int[2 * n]; int ch = 0; int j = 0;
            int[] arrA = new int[n]; int[] arrB = new int[n];
            AddMatrix(arrA); AddMatrix(arrB);
            for (int i = 0; i < n; i++)
            {
                if (arrB[i] % 2 == 0)
                {
                    arrC[j] = arrB[i];
                    j++;
                }
                arrC[j] = arrA[i];
                j++;
            }
            Array.Resize(ref arrC, j);
            PrintMatrix(arrA); PrintMatrix(arrB); PrintMatrix(arrC);
        }
    }
}
