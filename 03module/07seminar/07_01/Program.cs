using System;

namespace _07_01
{

    public struct Person: IComparable<Person>
    {
        private string name;
        private int age;
        private string lastName;

        public Person(string name, string lastName, string age)
        {
            this.name = name;
            this.lastName = lastName;
            if (int.TryParse(age, out int a) && a > 0)
                this.age = a;
            else
                throw new ArgumentOutOfRangeException();
        }

        public int CompareTo(Person person)
        {
            if (age > person.age) return -1;
            else if (age < person.age) return 1;
            else return 0;
        }

        public override string ToString() => "Name: " + name + " " + lastName + "\n" +"Age: " + age + "years";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of users: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("*****************************");

            string[] names = { "John", "George", "Kevin", "Steph", "James", "Joel" };
            string[] surnames = { "Embid", "Curry", "Harden", "Stampl", "Durant", "LeBron", "Washington" };

            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Random random_age = new Random();
                string age = random_age.Next(1,100).ToString();
                Random random_name = new Random();
                string name = names[random_name.Next(0,names.Length)];
                Random random_lastname = new Random();
                string lastName = surnames[random_lastname.Next(0, surnames.Length)];

                people[i] = new Person(name, lastName, age);
            }

            foreach (Person person in people)
                Console.WriteLine(person);

            Array.Sort(people);
            Console.WriteLine("*****************************");

            foreach (Person person in people)
                Console.WriteLine(person);

        }
    }
}
