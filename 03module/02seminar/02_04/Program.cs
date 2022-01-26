using System;

namespace _02_04
{
    class Plant
    {
        double growth = 0;
        double photosensitivity = 0;
        double frostresistance = 0;

        public double Growth
        {
            get => growth;
            set => growth = value;
        }

        public double Photosensitivity
        {
            get => photosensitivity;
            set
            {
                if (value > 0 && value < 100)
                    photosensitivity = value;
                else
                    photosensitivity = 0;
            }
        }

        public double Frostresistance
        {
            get => frostresistance;
            set
            {
                if (value > 0 && value < 100)
                    frostresistance = value;
                else
                    frostresistance = 0;
            }
        }

        public Plant(double g, double p, double f)
        {
            Growth = g;
            Photosensitivity = p;
            Frostresistance = f;
        }

        public override string ToString() => 
            $"Рост: {Growth} Cветочувствительность {Photosensitivity} Морозоустойчивость {Frostresistance}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Plant[] arr = new Plant[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Random random = new();
                Plant plant = new(random.Next(25, 100), random.Next(0, 100), random.Next(0, 80));
                arr[i] = plant;

            }
            Array.ForEach(arr, el => Console.WriteLine(el));
            Console.WriteLine("------------------------------------");

            Console.WriteLine("По убыванию роста:");
            Array.Sort(arr, delegate (Plant plant1, Plant plant2)
            {
                if (plant1.Growth < plant2.Growth)
                    return 1;
                if (plant1.Growth == plant2.Growth)
                    return 0;
                else return -1;
            });
            Array.ForEach(arr, el => Console.WriteLine(el));
            Console.WriteLine("------------------------------------");

            Console.WriteLine("По возрастанию морозоустойчивости:");
            Array.Sort(arr, (Plant plant1, Plant plant2) =>
            {
                if (plant1.Frostresistance > plant2.Frostresistance)
                    return 1;
                if (plant1.Frostresistance == plant2.Frostresistance)
                    return 0;
                else return -1;
            });
            Array.ForEach(arr, el => Console.WriteLine(el));
            Console.WriteLine("------------------------------------");

            Console.WriteLine("По чётности светоустойчивости:");
            Array.Sort(arr, (Plant p1, Plant p2) =>
            {
                if (p1.Photosensitivity % 2 != 0 && p2.Photosensitivity % 2 == 0)
                    return 1;
                if (p1.Photosensitivity == p2.Photosensitivity)
                    return 0;
                else return -1;
            });
            Array.ForEach(arr, el => Console.WriteLine(el));
        }
    }
}
