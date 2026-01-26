using System;

namespace foodStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            food food1 = new food();
            food1.SetTrans();
            food1.SetName("Pizza");
            food1.SetFlavor("Savory");
            food1.SetOrigin("Italy");

            food food2 = new food();
            food2.SetTrans();
            Console.WriteLine("Enter food name:");
            food2.SetName(Console.ReadLine());
            Console.WriteLine("Enter food flavor:");
            food2.SetFlavor(Console.ReadLine());
            Console.WriteLine("Enter where the food is from:");
            food2.SetOrigin(Console.ReadLine());

            food food3 = new food("Sushi", "Umami", "Japan");
            food3.SetTrans();

            Console.WriteLine("Enter food name:");
            string tempName = Console.ReadLine();
            Console.WriteLine("Enter food flavor:");
            string tempFlavor = Console.ReadLine();
            Console.WriteLine("Enter where the food is from:");
            string tempOrigin = Console.ReadLine();

            food food4 = new food(tempName, tempFlavor, tempOrigin);
            food4.SetTrans();

            Console.WriteLine($"The food store has {food1.GetTrans()} food items");

            displayFood(food1);
            displayFood(food2);
            displayFood(food3);
            displayFood(food4);
        }

        static void displayFood(food f)
        {
            Console.WriteLine("Food Information");
            Console.WriteLine($"Name: {f.GetName()}");
            Console.WriteLine($"Flavor: {f.GetFlavor()}");
            Console.WriteLine($"From: {f.GetOrigin()}");
            Console.WriteLine();
        }
    }

    class food
    {
        private static int _transactions = 0;

        private string _Name;
        private string _Flavor;
        private string _Origin;

        public food()
        {
            _Name = "";
            _Flavor = "";
            _Origin = "";
        }

        public food(string name, string flavor, string origin)
        {
            _Name = name;
            _Flavor = flavor;
            _Origin = origin;
        }

        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans()
        {
            return _transactions;
        }

        public string GetName()
        {
            return _Name;
        }

        public void SetName(string name)
        {
            _Name = name;
        }

        public string GetFlavor()
        {
            return _Flavor;
        }

        public void SetFlavor(string flavor)
        {
            _Flavor = flavor;
        }

        public string GetOrigin()
        {
            return _Origin;
        }

        public void SetOrigin(string origin)
        {
            _Origin = origin;
        }
    }
}
