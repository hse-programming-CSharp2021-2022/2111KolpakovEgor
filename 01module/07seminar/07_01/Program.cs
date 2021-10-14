using System;
using System.IO;
using System.Text;
namespace _07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("Введите кол-во чисел: ");
                int n = int.Parse(Console.ReadLine());
                Random rand = new Random();
                StringBuilder createText = new StringBuilder();
                for (var i = 0; i < n; i++)
                {
                    if (i % 5 == 0)
                        Console.WriteLine();
                    createText.Append(rand.Next(10, 100) + " ");
                }
                File.WriteAllText(path, createText.ToString(), Encoding.UTF8);
            }
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToInt(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                int[] chet = new int[1];
                int[] nechet = new int[1];
                int oddCount = 0;
                int evenCount = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        chet[evenCount] = i;
                        evenCount++;
                        Array.Resize(ref chet, evenCount + 1);
                    }
                    else if (arr[i] % 2 != 0)
                    {
                        nechet[oddCount] = i;
                        oddCount++;
                        Array.Resize(ref nechet, oddCount + 1);
                        arr[i] = 0;
                    }
                }
                Console.WriteLine("Массив четных индексов:");
                foreach (var i in chet)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Массив нечетных индексов:");
                foreach (var i in nechet)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Исходный массив чисел:");
                foreach (var i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[] StringArrayToInt(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                }
            }
            return arr;
        }
    }
}
