using System;

namespace SimpleInheritance
{
    class Animal
    {
        public string name;

        public Animal()
        {
            name = "";
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    class Cat : Animal
    {
        public string color;
        public string furLength;
        public string eyeColor;

        public Cat() : base()
        {
            color = "";
            furLength = "";
            eyeColor = "";
        }

        public Cat(string name, string color, string furLength, string eyeColor) : base(name)
        {
            this.color = color;
            this.furLength = furLength;
            this.eyeColor = eyeColor;
        }

        public void displayCatInfo()
        {
            Console.WriteLine("Cat Information...");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Fur Length: {furLength}");
            Console.WriteLine($"Eye Color: {eyeColor}");
        }
    }

    class Dog : Animal
    {
        public int age;
        public string size;
        public string color;

        public Dog() : base()
        {
            age = 0;
            size = "";
            color = "";
        }

        public Dog(string name, int age, string size, string color) : base(name)
        {
            this.age = age;
            this.size = size;
            this.color = color;
        }

        public void displayDogInfo()
        {
            Console.WriteLine("Dog Information...");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"Color: {color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            Cat cat1 = new Cat();
            cat1.name = "Bobby";
            cat1.color = "Tabby";
            cat1.furLength = "Short";
            cat1.eyeColor = "Green";
            cat1.displayCatInfo();

            Cat cat2 = new Cat("BabyKitty", "Brown", "Long", "Green");
            cat2.displayCatInfo();

            Dog dog1 = new Dog();
            dog1.name = "Cici";
            dog1.age = 9;
            dog1.size = "Medium";
            dog1.color = "Black";
            dog1.displayDogInfo();

            Dog dog2 = new Dog("Cooper", 8, "Large", "Tan");
            dog2.displayDogInfo();
        }
    }
}
