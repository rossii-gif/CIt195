 using System;

namespace immutableID
{
    class Program
    {
        class Student
        {
            public int Id { get; init; }   
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }

            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }

            public Student(int i)
            {
                Id = i;
                FirstName = "";
                LastName = "";
            }
        }

        static void Main(string[] args)
        {
            Student student1 = new Student(1001);

            student1.FirstName = "Bella";
            student1.LastName = "Rossi";

            Student student2 = new Student(1002, "Lisa", "Balbach");

            Console.WriteLine("Student 1:");
            Console.WriteLine($"ID: {student1.Id}");
            Console.WriteLine($"First Name: {student1.FirstName}");
            Console.WriteLine($"Last Name: {student1.LastName}");

            Console.WriteLine();

            Console.WriteLine("Student 2:");
            Console.WriteLine($"ID: {student2.Id}");
            Console.WriteLine($"First Name: {student2.FirstName}");
            Console.WriteLine($"Last Name: {student2.LastName}");
        }
    }
}