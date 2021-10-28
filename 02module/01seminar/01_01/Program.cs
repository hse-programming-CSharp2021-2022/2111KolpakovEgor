using System;

namespace _01_01
{
    class Point2D // internal
    {
        // private
        int x, y;

        public int X { get; set; } // новое поле, не знаем ничего...
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public double Distance
        {
            get { return Math.Sqrt(X * X + y * y); }
        }
        // Создаём конструктор
        public Point2D(int x = 0, int y = 0)
        {
            X = x; this.y = y;
        }

        public double Distance2(Point2D p2)
        {
            return Math.Sqrt(Math.Pow(X + p2.X, 2) + Math.Pow(Y + p2.Y, 2));
        }
        // переопределние из object
        public override string ToString()
        {
            return x + " " + y;
        }
        // Переопределяем "+"
        public static Point2D operator +(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.X + p2.X, p1.Y + p2.Y);
        }
        // Переопределяем "-"
        public static Point2D operator -(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.X - p2.X, p1.Y - p2.Y);
        }
        // Переопределяем Equals
        public override bool Equals(object obj)
        {
            Point2D p2 = (Point2D)obj;
            return X == p2.X && Y == p2.Y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D(10,50);
            Point2D point2 = new();
            point1.X = 10; point1.Y = 8;
            point2.X = 3; point2.Y = 15;
            Console.WriteLine(point1.ToString());
            Console.WriteLine(point1.GetHashCode());
            Console.WriteLine(point2.GetHashCode());
            Console.WriteLine(point1.Equals(point2));
            Console.WriteLine(point2.GetType());
            Console.WriteLine(point2 + point1);
        }
    }
}
