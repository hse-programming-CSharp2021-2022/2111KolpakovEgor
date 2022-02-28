using System;
using System.IO;

namespace _11__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Numbers.dat";
            using(BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                Random random = new Random();

                for (int i = 0; i < 10; i++)
                    binaryWriter.Write(random.Next(1, 101));
            }

            int[] arr = new int[10];

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = reader.ReadInt32();
                    Console.Write(arr[i] + " ");
                }     
            }
            Console.WriteLine("\n");

            int n = int.Parse(Console.ReadLine());

            int index = 0, res = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                if (Math.Abs(arr[i] - n) < res)
                {
                    res = Math.Abs(arr[i] - n);
                    index = i;
                }
            }
            arr[index] = n;

            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach(int i in arr)
                    binaryWriter.Write(i);
            }

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = reader.ReadInt32();
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
