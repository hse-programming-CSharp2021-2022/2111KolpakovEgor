using System;

namespace _01_04
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0,0){ }
        public double Ro
        {
            get
            {
                return X * X + Y * Y;
            }
        }
        public double Fi
        {
            get
            {
                if (X > 0 && Y >= 0)
                    return Math.Atan(Y / X);
                else if (X > 0 && Y < 0)
                    return Math.Atan(Y / X) + 2 * Math.PI;
                else if (X < 0)
                    return Math.Atan(Y / X) + Math.PI;
                else if (X == 0 && Y > 0)
                    return Math.Atan(Math.PI / 2);
                else if (X == 0 && Y < 0)
                    return Math.Atan(3 * Math.PI / 2);
                else
                    return 0;
            }
        }
        public string PointData
        {
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2}; Distance = {4:F2}";
                return string.Format(maket, X, Y, Ro, Fi, Distance);
            }
        }
        public double Distance
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                if (a.Distance >= b.Distance && a.Distance >= c.Distance)
                    if (b.Distance >= c.Distance)
                    {
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(a.PointData);
                    }
                    else
                    {
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(a.PointData);
                    }
                else if (c.Distance >= a.Distance && c.Distance >= b.Distance)
                    if (a.Distance >= b.Distance)
                    {
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(c.PointData);
                    }
                    else
                    {
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(c.PointData);
                    }
                else
                {
                    if (a.Distance >= c.Distance)
                    {
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(b.PointData);
                    }
                    else
                    {
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(b.PointData);
                    }
                }

            } while (x != 0 | y != 0);
        }
    }
}
