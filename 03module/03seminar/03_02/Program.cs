using System;

namespace _03_02
{
    class Dot
    {
        public delegate void CoordChanged(Dot dot);
        public event CoordChanged OnCoordChanged;

        public int X { get; set; }
        public int Y { get; set; }

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DotFlow()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new();
                int x = rnd.Next(-10, 10);
                int y = rnd.Next(-10, 10);
                Dot dot = new(x, y);

                if (x < 0 && y < 0)
                    OnCoordChanged(dot);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            void PrintInfo(Dot dot) => Console.WriteLine($"Координаты ({dot.X},{dot.Y})");
            Console.WriteLine("Введите X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            int y = int.Parse(Console.ReadLine());

            Dot dot = new(x, y);
            dot.OnCoordChanged += PrintInfo;
            dot.DotFlow();
        }
    }
}
