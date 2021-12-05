using System;

namespace _04_02
{
    abstract class Animals
    {
        public string AnimalName { get; protected set; }
        public int AnimalAge { get; protected set; }
        public abstract string AnimalSound { get; }
        public abstract string AnimalInfo();        
    }
    class Dog: Animals
    {
        bool IsTrained;
        public override string AnimalSound => "Гав";
        string DogBreed;
        public Dog(string name, int age, string dogbreed, bool trained) { AnimalName = name; AnimalAge = age; DogBreed = dogbreed; IsTrained = trained; }
        public override string AnimalInfo() =>
            $"{GetType()} Animal name = {AnimalName} Animal age = {AnimalAge} Animal sound = {AnimalSound} Dog breed = {DogBreed} Is trained = {IsTrained}";
    }
    class Cow: Animals
    {
        int AmountofMilk;
        public override string AnimalSound => "Мууу";
        public Cow(string name, int age, int amountOfMilk) { AnimalName = name; AnimalAge = age; AmountofMilk = amountOfMilk; }
        public override string AnimalInfo() =>
            $"{GetType()} Animal name = {AnimalName} Animal age = {AnimalAge} Animal sound = {AnimalSound} Amount of milk = {AmountofMilk}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Шарик", 3, "Бульдог", true);
            Cow c = new Cow("Мурка", 5, 10);
            Console.WriteLine(d.AnimalInfo());
            Console.WriteLine(c.AnimalInfo());
        }
    }
}
