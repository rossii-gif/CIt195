using System;

namespace AbstractAnimalClass
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Cat : Animal
    {
        public override string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public Cat()
        {
            Name = string.Empty;
            Breed = string.Empty;
            Age = 0;
        }

        public Cat(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public override string Describe()
        {
            return $"I am a {Breed} Cat\nMy name is {Name}\nI am {Age} years old";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat Cat1 = new Cat();
            Cat1.Name = "Bobby";
            Cat1.Breed = "American Shorthair";
            Cat1.Age = 17;

            Cat Cat2 = new Cat("Baby Kitty", "American Longhair", 15);

            Console.WriteLine(Cat1.whatAmI());
            Console.WriteLine(Cat1.Describe());
            Console.WriteLine();
            Console.WriteLine(Cat2.whatAmI());
            Console.WriteLine(Cat2.Describe());
        }
    }
}
