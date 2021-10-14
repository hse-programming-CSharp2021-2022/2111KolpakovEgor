using System;

namespace _03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case "2":
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case "3":
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case "4":
                    Console.WriteLine("Удовлетворительно");
                    break;
                case "5":
                    Console.WriteLine("Удовлетворительно");
                    break;
                case "6":
                    Console.WriteLine("Хорошо");
                    break;
                case "7":
                    Console.WriteLine("Хорошо");
                    break;
                case "8":
                    Console.WriteLine("Отлично");
                    break;
                case "9":
                    Console.WriteLine("Отлично");
                    break;
                case "10":
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}
