using System;
using System.Runtime.Serialization;
namespace _05_01
{
    class AnimalException : Exception
    {
        public AnimalException()
        {
        }
        public AnimalException(string message) : base(message)
        {
        }
        public AnimalException(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected AnimalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    abstract class Animal
    {
        public string Name { get; protected set; }
        int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                    age = value;
                else throw new AnimalException("value cannot be less then 0");
            }
        }
        abstract public string AnimalSound();
        abstract public string AnimalInfo();
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Кличка: {Name}, Возраст: {Age}, Звук: {AnimalSound()}";
        }
    }
    class Dog : Animal
    {
        public Dog(string name, int age, string type, bool isTrained) : base(name, age) { Type = type; IsTrained = isTrained; }
        public string Type { get; set; }
        public bool IsTrained { get; set; }
        public override string AnimalSound()
        {
            return "Гав";
        }
        public override string AnimalInfo()
        {
            string tr = IsTrained ? "Да" : "Нет";
            return this.ToString() + $", Парода: {Type}, Тренированная ли: {tr}";
        }
    }
    class Cow : Animal
    {
        public Cow(string name, int age, int countMilk) : base(name, age) { CountMilk = countMilk; }
        public int CountMilk { get; set; }
        public override string AnimalSound()
        {
            return "Му";
        }
        public override string AnimalInfo()
        {
            return this.ToString() + $", Кол-во молока: {CountMilk}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new IndexOutOfRangeException();                //int[] a = new int[1];                //a[10]++;                Dog d = new Dog("Шарик", -3, "Бульдог", true);
                Cow c = new Cow("Мурка", 5, 10);
                Console.WriteLine(c.AnimalInfo());
            }
            catch (ArgumentException ae)
            { 
                Console.WriteLine(ae.Message);
            }
            catch (IndexOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (AnimalException ae)
            {
                Console.WriteLine("!!!");
                Console.WriteLine(ae.Message);
            }
            catch (Exception ae)
            {
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}