using System;

namespace ClubInterface
{
    interface IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname();
    }

    class Member : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MembershipType { get; set; }
        public double MonthlyFee { get; set; }

        public Member()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = 0;
            MembershipType = string.Empty;
            MonthlyFee = 0.0;
        }

        public Member(int id, string firstName, string lastName,
                      int age, string membershipType, double monthlyFee)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MembershipType = membershipType;
            MonthlyFee = monthlyFee;
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }

        public string DisplayInfo()
        {
            return $"ID: {Id}\n" +
                   $"Name: {Fullname()}\n" +
                   $"Age: {Age}\n" +
                   $"Membership Type: {MembershipType}\n" +
                   $"Monthly Fee: ${MonthlyFee}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member(1, "Bella", "Rossi", 22, "Gold", 49.99);
            Console.WriteLine("Member 1 Information:");
            Console.WriteLine(member1.DisplayInfo());

            Console.WriteLine();

            Member member2 = new Member();
            member2.Id = 2;
            member2.FirstName = "Lisa";
            member2.LastName = "Balbach";
            member2.Age = 30;
            member2.MembershipType = "Silver";
            member2.MonthlyFee = 29.99;

            Console.WriteLine("Member 2 Information:");
            Console.WriteLine(member2.DisplayInfo());
        }
    }
}
