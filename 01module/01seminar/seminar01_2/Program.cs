using System;

namespace seminar01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 100 до 999: ");
            if (int.TryParse(Console.ReadLine(), out int numb))
            {
                Console.WriteLine("Первая цифра: " + numb / 100);
                numb -= numb / 100 * 100;
                Console.WriteLine("Вторая цифра: " + numb / 10);
                numb -= numb / 10 * 10;
                Console.WriteLine("Третья цифра: " + numb);
            }
            else
                Console.WriteLine("Некорректное значение переменной.");
        }
    }
}
