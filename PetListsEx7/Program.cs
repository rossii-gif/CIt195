using System;
using System.Collections.Generic;

namespace PetCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemonstrateQueue();
            DemonstrateStack();
            DemonstrateLinkedList();
            DemonstrateDictionary();
            DemonstrateHashSet();

            Console.ResetColor();
            Console.WriteLine("\nProgram complete. Press any key to exit.");
            Console.ReadKey();
        }

        static void DemonstrateQueue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---- Pets Waiting for Grooming (Queue) ----");

            Queue<string> groomingLine = new Queue<string>();

            groomingLine.Enqueue("Bobby");
            groomingLine.Enqueue("Baby Kitty");
            groomingLine.Enqueue("Cici");
            groomingLine.Enqueue("Cooper");
            groomingLine.Enqueue("Pluto");

            string searchPet = "Cooper";
            if (groomingLine.Contains(searchPet))
                Console.WriteLine(searchPet + " is in the grooming line.");
            else
                Console.WriteLine(searchPet + " is not in the grooming line.");

            string removedPet = groomingLine.Dequeue();
            Console.WriteLine("Removed from queue (finished grooming): " + removedPet);

            Console.WriteLine("Pets remaining in queue: " + groomingLine.Count);

            Console.WriteLine("Current grooming line:");
            foreach (var pet in groomingLine)
                Console.WriteLine(pet);

            Console.WriteLine();
            Console.ResetColor();
        }

        static void DemonstrateStack()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---- Pets Toys Pile (Stack) ----");

            Stack<string> toyStack = new Stack<string>();

            toyStack.Push("Ball");
            toyStack.Push("Fish Toy");
            toyStack.Push("Bone");
            toyStack.Push("Feather Toy");
            toyStack.Push("Squeaky Toy");

            if (toyStack.Contains("Bone"))
                Console.WriteLine("Bone is in the toy pile.");
            else
                Console.WriteLine("Bone is not in the toy pile.");

            string removedToy = toyStack.Pop();
            Console.WriteLine("Removed from stack (top toy): " + removedToy);

            Console.WriteLine("Toys remaining: " + toyStack.Count);

            Console.WriteLine("Current toy stack:");
            foreach (var toy in toyStack)
                Console.WriteLine(toy);

            Console.WriteLine();
            Console.ResetColor();
        }

        static void DemonstrateLinkedList()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---- Pets Available for Adoption (Linked List) ----");

            LinkedList<string> adoptablePets = new LinkedList<string>();

            adoptablePets.AddLast("Angel");
            adoptablePets.AddLast("Rue");
            adoptablePets.AddLast("Penny");
            adoptablePets.AddLast("Daisy");
            adoptablePets.AddLast("Ned");

            Console.WriteLine("First pet: " + adoptablePets.First.Value);
            Console.WriteLine("Last pet: " + adoptablePets.Last.Value);

            LinkedListNode<string> middleNode = adoptablePets.Find("Penny");
            if (middleNode != null)
            {
                adoptablePets.AddAfter(middleNode, "Nala");
                Console.WriteLine("Added Nala after Penny.");
            }

            adoptablePets.RemoveFirst();
            Console.WriteLine("Removed first pet from list.");

            Console.WriteLine("Number of adoptable pets: " + adoptablePets.Count);

            Console.WriteLine("Current adoptable pets:");
            foreach (var pet in adoptablePets)
                Console.WriteLine(pet);

            Console.WriteLine();
            Console.ResetColor();
        }

        static void DemonstrateDictionary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---- Pet Names and Types (Dictionary) ----");

            Dictionary<string, string> petTypes = new Dictionary<string, string>();

            petTypes.Add("Bobby", "Short Haired Cat");
            petTypes.Add("Baby Kitty", "Long Haired Cat");
            petTypes.Add("Cici", "German Short Haired Pointer");
            petTypes.Add("Cooper", "Blood Hound");
            petTypes.Add("Pluto", "Siberian Cat");

            Console.WriteLine("Pet Names:");
            foreach (var key in petTypes.Keys)
                Console.WriteLine(key);

            Console.WriteLine("\nPet Types:");
            foreach (var value in petTypes.Values)
                Console.WriteLine(value);

            Console.WriteLine("\nPet Details:");
            foreach (var pair in petTypes)
                Console.WriteLine(pair.Key + " is a " + pair.Value);

            petTypes.Remove("Goldie");
            Console.WriteLine("\nRemoved Goldie.");

            Console.WriteLine("Total pets in dictionary: " + petTypes.Count);

            Console.WriteLine();
            Console.ResetColor();
        }

        static void DemonstrateHashSet()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---- Pet Tricks (HashSet) ----");

            HashSet<string> tricks1 = new HashSet<string>()
            { "Sit", "Stay", "Roll Over", "Fetch", "Jump" };

            HashSet<string> tricks2 = new HashSet<string>()
            { "Speak", "Shake", "Stay", "Fetch", "Spin" };

            HashSet<string> tricks3 = new HashSet<string>()
            { "Play Dead", "Jump", "Spin", "Sit", "Crawl" };

            tricks1.UnionWith(tricks2);
            tricks1.UnionWith(tricks3);

            Console.WriteLine("All unique tricks:");
            foreach (var trick in tricks1)
                Console.WriteLine(trick);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}