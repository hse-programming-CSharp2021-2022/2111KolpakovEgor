using System;
using Figure;
namespace ConsoleApp1
{
    class Program
    {
        public static int Sort(Shape f1, Shape f2)
        {
            if (f1 is Circle && f2 is Sphere)
                return 1;
            if (f1 is Sphere && f2 is Cylinder)
                return -1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            {
                Random rnd = new Random();
                int rnd1 = rnd.Next(3, 6);
                int rnd2 = rnd.Next(3, 6);
                int rnd3 = rnd.Next(3, 6);
                Shape[] figure = new Shape[rnd1 + rnd2 + rnd3];
                for (int i = 0; i < rnd1; i++)
                {
                    int random = rnd.Next(1, 100);
                    figure[i] = new Circle(random);
                    Console.WriteLine($"{i} R = {random}");
                }
                for (int i = rnd1; i < rnd2; i++)
                {
                    int r = rnd.Next(1, 100);
                    int h = rnd.Next(1, 100);
                    Console.WriteLine($"{i} R = {r}, H = {h}");
                    figure[i] = new Cylinder(r, h);
                }
                for (int i = rnd2; i < rnd3; i++)
                {
                    int r = rnd.Next(1, 100);
                    Console.WriteLine($"{i} R = {r}");
                    figure[i] = new Sphere(r);
                }
                foreach (var k in figure)
                    Console.WriteLine(k);

                Console.WriteLine("-------------AREA---------------");
                for (int i = 0; i < figure.Length; ++i)
                    Console.WriteLine($"{figure[i].Area()}");

                Console.WriteLine("---------------FIGURE-----------------");
                for (int i = 0; i < figure.Length; ++i)
                {
                    Console.WriteLine((figure[i] is Cylinder ? "Cylinder" : (figure[i] is Sphere ? "Sphere" : "Circle")) + '\t' + figure[i].Area());
                }

                Console.WriteLine();
                Array.Sort(figure, Sort);

                for (int i = 0; i < figure.Length; ++i)
                {
                    Console.WriteLine((figure[i] is Cylinder ? "Cylinder" : (figure[i] is Sphere ? "Sphere" : "Circle")) + '\t' + figure[i].Area());
                }
            }
        }
    }
}
