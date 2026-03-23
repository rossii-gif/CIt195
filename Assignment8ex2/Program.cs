using System;

namespace Assignment8ex2
{   
    public class MathSolutions
    {
        public delegate double MathOperation(double x, double y);

        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        static void Main(string[] args)
        {
            MathSolutions answer = new MathSolutions();

            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            Action<double, double> smallerAction = answer.GetSmaller;

            Func<double, double, double> sumFunc = answer.GetSum;

            MathOperation productDelegate = answer.GetProduct;

            Console.WriteLine($" {num1} + {num2} = {sumFunc(num1, num2)}");
            Console.WriteLine($" {num1} * {num2} = {productDelegate(num1, num2)}");
            smallerAction(num1, num2);
        }
    }
}