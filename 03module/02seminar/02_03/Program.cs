using System;

namespace _02_03
{
    delegate string ConvertRule(string s);
    class Converter
    {
        public string Convert(string str, ConvertRule convertRule)
        {
            return convertRule(str);
        }
    }

    class Program
    {
        public static string RemoveDigits(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    res += str[i];
            }
            return res;
        }

        public static string RemoveSpaces(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    res += str[i];
            }
            return str;
        }
        static void Main(string[] args)
        {
            string[] arr = new string[] { "dfere dff 33 f3r", "vr4r5 ffr3 dff9", "rffr40fv frr9rr r8r30" };

            ConvertRule convertRule1 = RemoveDigits;
            Console.WriteLine(convertRule1.Invoke(arr[0]));
            Console.WriteLine();

            ConvertRule convertRule2 = RemoveSpaces;
            Console.WriteLine(convertRule2.Invoke(arr[1]));
            Console.WriteLine();

            ConvertRule convertRule3 = convertRule1 + convertRule2;
            Console.WriteLine(convertRule3.Invoke(arr[2]));
            Console.WriteLine();

            Console.WriteLine(convertRule3.GetInvocationList());
            
        }
    }
}
