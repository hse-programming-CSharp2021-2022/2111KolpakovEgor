using System;

namespace _04_02
{
    class Program
    {
        public static bool Transform(ref uint numb)
        {
            uint k = numb; int count = 0;
            uint t = numb;
            while (k > 0)
            {
                k /= 10;
                count++;
            }
            uint[] arr = new uint[count];
            int i = 0;
            while (t > 0)
            {
                arr[i] = t % 10;
                i++;
                t /= 10;
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            string s = "";
            foreach (char m in arr)
                s += m;
            Console.WriteLine(s);
            numb = uint.Parse(s);
            return true;
        }
        static void Main(string[] args)
        {
            uint k = uint.Parse(Console.ReadLine());
            Console.WriteLine(Transform(ref k));
        }
    }
}
