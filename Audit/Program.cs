using System;

namespace Audit
{
    class Auditor
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Business
    {
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public string BusinessAddress { get; set; }
        public Auditor BusinessAuditor { get; set; }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Business Information");
            Console.WriteLine("Name: " + BusinessName);
            Console.WriteLine("Type: " + BusinessType);
            Console.WriteLine("Address: " + BusinessAddress);

            Console.WriteLine("\nAuditor Information");
            Console.WriteLine("Name: " + BusinessAuditor.Name);
            Console.WriteLine("Phone: " + BusinessAuditor.PhoneNumber);

            Console.ResetColor();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Audit Containment Example\n");

            Auditor auditor = new Auditor
            {
                Name = "Bella Rossi",
                PhoneNumber = "555-123-4567"
            };

            Business business = new Business
            {
                BusinessName = "The Cottage",
                BusinessType = "Restaurant",
                BusinessAddress = "472 Munson Ave, Traverse City, MI",
                BusinessAuditor = auditor
            };

            business.Display();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}