using System;

namespace _05_02
{
    class Program
    {
        public static char[] AddMas(char[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = (char)rnd.Next('A', 'Z' + 1);
            return arr;
        }
        public static void PrintMas(char[] arr)
        {
            foreach (char n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] arr = new char[n]; char[] arrCopy = new char[n];
            AddMas(arr); PrintMas(arr);
            Array.Copy(arr, arrCopy, n);
            Array.Sort(arrCopy);
            PrintMas(arrCopy);
            Array.Reverse(arrCopy);
            PrintMas(arrCopy);
        }
    }
}
