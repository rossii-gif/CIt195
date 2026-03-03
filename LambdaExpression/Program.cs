using System;

namespace LambdaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Lambda Expressions Calculator ===\n");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Func<double, double, double> addNumbers = 
                (x, y) => x + y;

            Func<double, double, double> multiplyNumbers = 
                (x, y) => x * y;

            Func<double, double, double> smallerNumber = 
                (a, b) =>
                {
                    if (a < b)
                        return a;
                    else
                        return b;
                };

            Console.WriteLine($"The sum of the numbers is: {addNumbers(num1, num2)}");
            Console.WriteLine($"The product of the numbers is: {multiplyNumbers(num1, num2)}");
            Console.WriteLine($"The smaller number is: {smallerNumber(num1, num2)}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}