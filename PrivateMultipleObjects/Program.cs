using System;

namespace PrivateMultipleObjects
{
    class Cat
    {
        private string _name;
        private int _age;
        private string _color;

        public Cat()
        {
            _name = string.Empty;
            _age = 0;
            _color = string.Empty;
        }

        public Cat(string name, int age, string color)
        {
            _name = name;
            _age = age;
            _color = color;
        }

        public string getName() { return _name; }
        public int getAge() { return _age; }
        public string getColor() { return _color; }
        public void setName(string name) { _name = name; }
        public void setAge(int age) { _age = age; }
        public void setColor(string color) { _color = color; }

        public virtual void addChange()
        {
            Console.Write("Name=");
            setName(Console.ReadLine());
            Console.Write("Age=");
            setAge(int.Parse(Console.ReadLine()));
            Console.Write("Color=");
            setColor(Console.ReadLine());
        }

        public virtual void print()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {getName()}");
            Console.WriteLine($"Age: {getAge()}");
            Console.WriteLine($"Color: {getColor()}");
        }
    }

    class RescueCat : Cat
    {
        private string _rescueLocation;

        public RescueCat() : base()
        {
            _rescueLocation = string.Empty;
        }

        public RescueCat(string name, int age, string color, string rescueLocation)
            : base(name, age, color)
        {
            _rescueLocation = rescueLocation;
        }

        public void setRescueLocation(string location) { _rescueLocation = location; }
        public string getRescueLocation() { return _rescueLocation; }

        public override void addChange()
        {
            base.addChange();
            Console.Write("Rescue Location=");
            _rescueLocation = Console.ReadLine();
        }

        public override void print()
        {
            base.print();
            Console.WriteLine($"Rescue Location: {getRescueLocation()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cats do you want to enter?");
            int maxCats;
            while (!int.TryParse(Console.ReadLine(), out maxCats))
                Console.WriteLine("Please enter a whole number");

            Cat[] cats = new Cat[maxCats];

            Console.WriteLine("How many rescue cats do you want to enter?");
            int maxRescue;
            while (!int.TryParse(Console.ReadLine(), out maxRescue))
                Console.WriteLine("Please enter a whole number");

            RescueCat[] rescueCats = new RescueCat[maxRescue];

            int choice, rec, type;
            int catCounter = 0, rescueCounter = 0;

            choice = Menu();

            while (choice != 4)
            {
                Console.WriteLine("Enter 1 for RescueCat or 2 for Cat");
                while (!int.TryParse(Console.ReadLine(), out type) || (type != 1 && type != 2))
                    Console.WriteLine("1 for RescueCat or 2 for Cat");

                switch (choice)
                {
                    case 1:
                        if (type == 1)
                        {
                            if (rescueCounter < maxRescue)
                            {
                                rescueCats[rescueCounter] = new RescueCat();
                                rescueCats[rescueCounter].addChange();
                                rescueCounter++;
                            }
                            else
                                Console.WriteLine("Maximum number of rescue cats reached.");
                        }
                        else
                        {
                            if (catCounter < maxCats)
                            {
                                cats[catCounter] = new Cat();
                                cats[catCounter].addChange();
                                catCounter++;
                            }
                            else
                                Console.WriteLine("Maximum number of cats reached.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter the record number you want to change: ");
                        while (!int.TryParse(Console.ReadLine(), out rec))
                            Console.Write("Enter the record number you want to change: ");
                        rec--;
                        if (type == 1)
                        {
                            while (rec < 0 || rec >= rescueCounter)
                            {
                                Console.Write("Out of range, try again: ");
                                while (!int.TryParse(Console.ReadLine(), out rec))
                                    Console.Write("Enter the record number: ");
                                rec--;
                            }
                            rescueCats[rec].addChange();
                        }
                        else
                        {
                            while (rec < 0 || rec >= catCounter)
                            {
                                Console.Write("Out of range, try again: ");
                                while (!int.TryParse(Console.ReadLine(), out rec))
                                    Console.Write("Enter the record number: ");
                                rec--;
                            }
                            cats[rec].addChange();
                        }
                        break;

                    case 3:
                        if (type == 1)
                        {
                            for (int i = 0; i < rescueCounter; i++)
                                rescueCats[i].print();
                        }
                        else
                        {
                            for (int i = 0; i < catCounter; i++)
                                cats[i].print();
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
                choice = Menu();
            }
        }

        private static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}
