using System;

namespace seminar02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int m = p;
            int n = 0;
            while (m > 0)
            {
                m /= 10;
                n++;
            }
            int[] arr = new int[n];
            int i = 0;
            while (p > 0)
            {
                arr[i] = p % 10;
                p /= 10;
                i++;
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int a in arr)
                Console.Write(a);
        }
    }
}
