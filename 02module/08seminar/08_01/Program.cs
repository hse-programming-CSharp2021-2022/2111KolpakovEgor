using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
namespace Task01
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Pocket { get; set; }
        public abstract void Receive(string present);
        public Person(string name)
        {
            Name = name;
            Pocket = string.Empty;
        }
        public override string ToString()
        {
            return Name + " " + Pocket;
        }
    }
    class SnowMaiden : Person
    {
        static Random random = new Random();
        private string CreateGift()
        {
            int n = random.Next(4, 11);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                sb.Append((char)(random.Next('a', 'z' + 1)));
            return sb.ToString();
        }
        public string[] CreatePresents(int amount)
        {
            string[] gifts = new string[amount];
            for (int i = 0; i < gifts.Length; i++)
                gifts[i] = CreateGift();
            return gifts;
        }
        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else
                throw new ArgumentException();
        }
        public SnowMaiden(string name) : base(name) { }
    }
    class Santa : Person
    {
        List<string> sack;
        static Random random = new Random();
        public void Request(SnowMaiden snowMaiden, int amount)
        {
            string[] gifts = snowMaiden.CreatePresents(amount);
            sack.AddRange(gifts);
        }
        public Santa(string name) : base(name)
        {
            sack = new List<string>();
        }
        public void Give(Person person)
        {
            if (sack.Count > 0)
            {
                int n = random.Next(0, sack.Count);
                person.Receive(sack[n]);
                sack.RemoveAt(n);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else
                throw new ArgumentException();
        }
    }
    class Child : Person
    {
        public string additionalPocket { get; set; }
        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else if (additionalPocket.Equals(string.Empty))
                additionalPocket = present;
            else
                throw new ArgumentException();
        }
        public Child(string name) : base(name)
        {
            additionalPocket = string.Empty;
        }
        public override string ToString()
        {
            return Name + " " + Pocket + " " + additionalPocket;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Santa santa = new Santa("Santa");
            SnowMaiden snowMaiden = new SnowMaiden("SnowMaiden");
            Random random = new Random();
            List<Person> people = new List<Person>();
            people.Add(santa);
            people.Add(snowMaiden);
            int n = 10;

            for (int i = 2; i < 2 + n; i++)
            {
                people.Add(new Child(i.ToString()));
                Console.WriteLine(people[i]);
            }

            santa.Request(snowMaiden, random.Next(1, 5));

            for (int i = 0; i < n + 2; i++)
            {
                int prob = random.Next(0, 101);
                if (prob > 10)
                    santa.Give(people[random.Next(1, n + 2)]);
                else
                    santa.Give(people[0]);
                santa.Request(snowMaiden, random.Next(1, 5));
            }
        }
    }
}
