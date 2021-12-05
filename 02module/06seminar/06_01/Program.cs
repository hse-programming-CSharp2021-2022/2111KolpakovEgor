using System;
using System.IO;
using System.Text;

namespace _06_01
{
    public class MyException : Exception
    {
        public MyException() : base() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try // 1
            {
                int[] arr = new int[2];
                Console.WriteLine(arr[3]);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("За рамки массива выходить нельзя!");
            }

            try //2
            {
                int k = 0;
                Console.WriteLine(5 / k);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль запрещено!");
            }

            try // 3
            {
                string s = "Hi";
                int.Parse(s);
            }
            catch (FormatException)
            {
                Console.WriteLine("Нельзя преобразовать строку в число!");
            }

            try //4
            {
                object obj = "--";
                int x = (int)obj;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Нельзя привести тип!");
            }

            try //5
            {
                Console.WriteLine("-_-".Substring(10000));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Получаем строку большего размера.");
            }

            try //6
            {
                string myS = null;
                Console.WriteLine("Hi".IndexOf(myS));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null аргумент!");
            }

            try //7
            {
                using (StreamReader sr = new StreamReader("My file")) { }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!");
            }

            try //8
            {
                int[,] arr = new int[33, 44];
                Array.Sort(arr);
            }
            catch (RankException)
            {
                Console.WriteLine("Массив с неверным числом размерностей!");
            }

            try //9
            {
                Directory.SetCurrentDirectory("Hi...");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Директива не найдена!");
            }

            try //10
            {
                throw new MyException();
            }
            catch(MyException)
            {
                Console.WriteLine("Моя ошибочка!");
            }

        }
    }
}
