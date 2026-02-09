using System;

namespace AnimalInheritance
{
    class Animal
    {
        private string name;    
        protected string type;  
        public string color;    

        public void setName(string name)
        {
            this.name = name;
        }

        public virtual string getName()
        {
            return this.name;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public virtual string getType()
        {
            return this.type;
        }
    }

    class Cat : Animal
    {
        private string breed;
        protected string size;
        public string sizePublic;

        public Cat() { }

        public Cat(string name, string color, string breed, string size)
        {
            setName(name);
            this.color = color;
            this.breed = breed;
            this.size = size;
            this.type = "Cat";
        }

        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public string getBreed()
        {
            return this.breed;
        }

        public void setSize(string size)
        {
            this.size = size;
        }

        public string getSize()
        {
            return this.size;
        }

        public override string getName()
        {
            return "Cat Name: " + base.getName();
        }

        public override string getType()
        {
            return "Animal Type: " + base.getType();
        }

        public void displayCatInfo()
        {
            Console.WriteLine("Cat Information...");
            Console.WriteLine(getName());
            Console.WriteLine(getType());
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Breed: {breed}");
            Console.WriteLine($"Size: {size}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.setName("Sparky");
            myAnimal.setType("Dog");
            myAnimal.color = "White";

            Console.WriteLine("Animal Information...");
            Console.WriteLine($"Name: {myAnimal.getName()}");
            Console.WriteLine($"Type: {myAnimal.getType()}");
            Console.WriteLine($"Color: {myAnimal.color}");
            Console.WriteLine();

            Cat myCat = new Cat("Bobby", "Tabby", "Short-Haired", "Medium");

            myCat.displayCatInfo();
        }
    }
}
