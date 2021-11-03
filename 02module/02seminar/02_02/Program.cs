using System;

namespace _02_02
{
    class ConsolePlate
    {
        char _plateChar;
        ConsoleColor _plateColor;
        ConsoleColor _consoleColor;
        public ConsolePlate()
        {
            _plateChar = 'A';
        }
        public ConsolePlate(char value, ConsoleColor color, ConsoleColor color2)
        {
            _plateChar = value;
            _plateColor = color;
            _consoleColor = color2;

        }
        public char PlateChar
        {
            set
            {
                if (value >= 41 && value <= 66)
                    _plateChar = value;
                else
                    _plateChar = 'A';
            }
            get { return _plateChar; }
        }
        public ConsoleColor PlateColor
        {
            set { _plateColor = value; }
            get { return _plateColor; }
        }
        public ConsoleColor Con_Color
        {
            set
            {
                if (value != _plateColor)
                    _consoleColor = value;
                else if (value != ConsoleColor.DarkMagenta)
                    _consoleColor = ConsoleColor.DarkMagenta;
                else
                    _consoleColor = ConsoleColor.DarkBlue;
            }
            get { return _consoleColor; }
        }
        public void Print(ConsolePlate cp)
        {
            char c = cp.PlateChar;
            Console.ForegroundColor = cp.PlateColor;
            Console.BackgroundColor = cp.Con_Color;
            Console.Write(c);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate first = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate second = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            ConsolePlate[] arr = new ConsolePlate[] { first, second };
            int n;
            do
                Console.Write("Введите N: ");
            while (!(int.TryParse(Console.ReadLine(), out n) && n >= 2 && n  < 35));
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        first.Print(arr[new Random().Next(0, arr.Length)]);
                        Console.WriteLine();
                    }
                    else
                        first.Print(arr[new Random().Next(0, arr.Length)]);
                }

        }
    }
}
