using System;

namespace _07_01
{
    abstract class Figure
    {
        public Point[] points;
        public int Lenght { get; }
        public abstract double Area();
        public Figure(Point[] arr)
        {
            int t = 0;
            foreach (var point in arr)
            {
                points[t] = point;
                t++;
            }
        }
        public abstract double Radius();
        public Point Centre()
        {
            double x = 0, y = 0;
            for(int i = 0; i < points.Length; i++)
            {
                x += points[i].X;
                y += points[i].Y;
            }
            x = x / points.Length;
            y = y / points.Length;
            return new Point(x, y);
        }
        public bool Cross(Figure figure)
        {
            double xDiff = Math.Abs(figure.Centre().X - Centre().X);
            double yDiff = Math.Abs(figure.Centre().Y - Centre().Y);

            double centreDiff = Math.Sqrt(xDiff * xDiff + yDiff * yDiff);

            if (centreDiff > figure.Radius() + Radius()) //Не пересекаются
                return false;
            return true;
        }
        public override string ToString()
        {
            string res = "";
            foreach (var point in points)
                res += point.ToString() + "\t";
            res += "\n" + "Длина стороны:" + Lenght;
            res += "\n" + "Тип фигуры:" + GetType();

            return res;
        }
    }
}
