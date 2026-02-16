using System;

namespace InterfaceCats
{
    interface IAnimal
    {
        string Name { get; set; }
        string Color { get; set; }

        string Describe();
    }

    class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Cat()
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
            Breed = string.Empty;
        }

        public Cat(string name, string color, int age, string breed)
        {
            Name = name;
            Color = color;
            Age = age;
            Breed = breed;
        }

        public string Describe()
        {
            return $"Name: {Name}\nColor: {Color}\nAge: {Age}\nBreed: {Breed}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat defaultCat = new Cat();
            defaultCat.Name = "Bobby";
            defaultCat.Color = "Tabby";
            defaultCat.Age = 17;
            defaultCat.Breed = "American Shorthair";

            Cat paramCat = new Cat("BabyKitty", "Brown", 15, "American Longhair");

            Console.WriteLine("Default Cat:");
            Console.WriteLine(defaultCat.Describe());
            Console.WriteLine();
            Console.WriteLine("Parameterized Cat:");
            Console.WriteLine(paramCat.Describe());
        }
    }
}
