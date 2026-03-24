using System;

namespace RestaurantInventoryExample
{
    public class InventoryItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }

        public static InventoryItem operator ++(InventoryItem item)
        {
            item.Quantity++;
            return item;
        }

        public static InventoryItem operator +(InventoryItem item, int amount)
        {
            item.Quantity += amount;
            return item;
        }

        public static bool operator >(InventoryItem item1, InventoryItem item2)
        {
            return item1.Quantity > item2.Quantity;
        }

        public static bool operator <(InventoryItem item1, InventoryItem item2)
        {
            return item1.Quantity < item2.Quantity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem burgers = new InventoryItem
            {
                ItemName = "Burgers",
                Quantity = 10,
                PricePerUnit = 5.99
            };

            InventoryItem pizzas = new InventoryItem
            {
                ItemName = "Pizzas",
                Quantity = 15,
                PricePerUnit = 8.99
            };

            Console.WriteLine("Original Inventory:");
            Console.WriteLine($"{burgers.ItemName}: {burgers.Quantity}");
            Console.WriteLine($"{pizzas.ItemName}: {pizzas.Quantity}");
            Console.WriteLine();

            burgers++;
            Console.WriteLine("After restocking 1 burger:");
            Console.WriteLine($"{burgers.ItemName}: {burgers.Quantity}");
            Console.WriteLine();

            pizzas = pizzas + 5;
            Console.WriteLine("After adding 5 pizzas:");
            Console.WriteLine($"{pizzas.ItemName}: {pizzas.Quantity}");
            Console.WriteLine();

            Console.WriteLine("Comparing inventory quantities:");
            if (burgers > pizzas)
            {
                Console.WriteLine("Burgers have more stock than pizzas.");
            }
            else if (burgers < pizzas)
            {
                Console.WriteLine("Pizzas have more stock than burgers.");
            }
            else
            {
                Console.WriteLine("Both have equal stock.");
            }

            Console.WriteLine();

            burgers = burgers + 10;

            Console.WriteLine("After adding 10 burgers:");
            Console.WriteLine($"{burgers.ItemName}: {burgers.Quantity}");

            if (burgers > pizzas)
            {
                Console.WriteLine("Now burgers have more stock than pizzas.");
            }
        }
    }
}