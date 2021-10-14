using System;
using System.Text;

namespace _06_01
{
    class Program
    {
        public static StringBuilder Reduction(string s)
        {
            char[] arr = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if ("AEIOUYaeiouy".Contains(arr[i].ToString()))
                {
                    if (i == 0)
                    {
                        sb.Append(arr[i].ToString().ToUpper());
                        return sb;
                    }
                    else
                    {
                        sb.Append(arr[i]);
                        return sb;
                    }
                }
                else
                {
                    if (i == 0)
                        sb.Append(arr[i].ToString().ToUpper());
                    else
                        sb.Append(arr[i]);
                }
            }
            return sb;
        }
        static void Main(string[] args)
        {
            StringBuilder res = new StringBuilder(); 
            string[] arr = Console.ReadLine().Split(" ");
            foreach (string s in arr)
                res.Append(Reduction(s));
            Console.WriteLine(res);
        }
    }
}
