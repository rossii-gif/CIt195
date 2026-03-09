using System;
using System.Collections.Generic;
using System.Linq;

namespace FamousPeopleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

            Console.WriteLine("a) People born after 1900:");
            var queryA = from p in stemPeople
                         where p.BirthYear > 1900
                         select p;
            foreach (var person in queryA)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            Console.WriteLine("b) People with two lowercase 'l's in their name:");
            var queryB = from p in stemPeople
                         where p.Name.Count(c => c == 'l') >= 2
                         select p;
            foreach (var person in queryB)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            Console.WriteLine("c) Count of people born after 1950:");
            var queryC = from p in stemPeople
                         where p.BirthYear > 1950
                         select p;
            Console.WriteLine(queryC.Count());
            Console.WriteLine();

            Console.WriteLine("d) People with birth years between 1920 and 2000 and count:");
            var queryD = from p in stemPeople
                         where p.BirthYear >= 1920
                         where p.BirthYear <= 2000
                         select p;
            foreach (var person in queryD)
                Console.WriteLine(person.Name);
            Console.WriteLine("Count: " + queryD.Count());
            Console.WriteLine();

            Console.WriteLine("e) List sorted by BirthYear:");
            var queryE = from p in stemPeople
                         orderby p.BirthYear
                         select p;
            foreach (var person in queryE)
                Console.WriteLine($"{person.Name} - {person.BirthYear}");
            Console.WriteLine();

            Console.WriteLine("f) People who died after 1960 but before 2015, sorted by name:");
            var queryF = from p in stemPeople
                         where p.DeathYear > 1960
                         where p.DeathYear < 2015
                         orderby p.Name
                         select p;
            foreach (var person in queryF)
                Console.WriteLine($"{person.Name} - {person.DeathYear}");
        }
    }

    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
}