using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();

        Console.WriteLine("How many random integers would you like to generate?");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = r.Next(1, 11); 
        }

        Console.WriteLine("\nRandom numbers generated:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        int sum = Add(numbers);
        int product = Multiply(numbers);

        Console.WriteLine($"\nTotal (Addition) = {sum}");
        Console.WriteLine($"Total (Multiplication) = {product}");
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1; 
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
