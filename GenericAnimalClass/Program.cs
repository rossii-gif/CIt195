using System;

public class Animal<T>
{
    private T data;

    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }

    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main()
    {
        Animal<string> animalName = new Animal<string>("Cat");

        Animal<string> animalHabitat = new Animal<string>("House");

        Animal<bool> endangered = new Animal<bool>(false);

        Animal<bool> cuteness = new Animal<bool>(true);

        Animal<int> averageLifespan = new Animal<int>(20);

        Console.WriteLine("\n--- Animal Information ---");

        Console.WriteLine("Name: " + animalName.getAnimal());
        Console.WriteLine("Habitat: " + animalHabitat.getAnimal());
        Console.WriteLine("Endangered: " + endangered.getAnimal());
        Console.WriteLine("Cuteness: " + cuteness.getAnimal());
        Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal() + " years");
    }
}
