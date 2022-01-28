using System;

namespace _06_01
{
    public abstract class Animal
    {
        public int Age { get; set; }    
        public Animal(int age)
        {
            Age = age;  
        }
    }

    public interface IJump
    {
        public int Height { get; set; }
        public void Jump();
    }

    public interface IRun
    {
        public int Speed { get; set; }
        public void Run();
    }

    public class Cockroach: Animal, IRun
    {
        public int Speed { get; set; }
        public Cockroach(int age, int speed) : base(age)
        {
            Speed = speed;
            Age = age;
        }
        public void Run() { Console.WriteLine($"Таракан побежал со скорость {Speed}"); }
    }

    public class Kangaroo: Animal, IJump
    {
        public int Height { get; set; }
        public Kangaroo(int age, int height): base(age)
        {
            Age = age;
            Height = height;
        }
        public void Jump() { Console.WriteLine($"Кенгуру подпрыгнул на высоту {Height}"); }
    }

    public class Cheetah: Animal, IJump, IRun
    {
        public int Height { get; set; }
        public int Speed { get; set; }
        public Cheetah(int age, int speed, int height) : base(age)
        {
            Age = age;
            Speed = speed;
            Height = height;
        }

        public void Run() => Console.WriteLine($"Гепард побежал со скоростью {Speed}");
        public void Jump() => Console.WriteLine($"Гепард подпрыгнул на высоту {Height}");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5];
            Random random = new Random();
            animals[0] = new Cockroach(random.Next(0, 100), random.Next(0, 100));
            animals[1] = new Kangaroo(random.Next(0, 100), random.Next(0, 100));
            animals[2] = new Cheetah(random.Next(0, 100), random.Next(0, 100), random.Next(0,100));
            animals[3] = new Cockroach(random.Next(0, 100), random.Next(0, 100));
            animals[4] = new Kangaroo(random.Next(0, 100), random.Next(0, 100));

            Array.ForEach(animals,el => Console.WriteLine(el));
        }
    }
}
