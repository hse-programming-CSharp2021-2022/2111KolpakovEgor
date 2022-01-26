using System;

namespace _03_01
{
    delegate void SquareSizeChanged(double value);
    class Square
    {
        public Square(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        private double x1;
        private double x2;
        private double y1;
        private double y2;

        public event SquareSizeChanged OnSizeChanged;
        public double X1
        {
            get => x1;
            set => OnSizeChanged(Math.Abs(value - X2));
        }
        public double Y1
        {
            get => y1;
            set => OnSizeChanged(Math.Abs(value - Y2));
        }
        public double X2
        {
            get => x2;
            set => OnSizeChanged(Math.Abs(value - X1));
        }
        public double Y2
        {
            get => y2;
            set => OnSizeChanged(Math.Abs(value - Y1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            static void SquareConsoleInfo(double x) => Console.WriteLine(Math.Round(x,2));

            Console.WriteLine("Введите X1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите X2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y2:");
            double y2 = double.Parse(Console.ReadLine());

            Square square = new(x1, y1, x2, y2);

            square.OnSizeChanged += SquareConsoleInfo;

            Console.WriteLine("Сколько раз хотите изменить значение?");
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 0; i < n; i++)
            {
                double new_x2 = double.Parse(Console.ReadLine());
                double new_y2 = double.Parse(Console.ReadLine());
                square.X2 = new_x2;
                square.Y2 = new_y2;
            }
        }
    }
}
