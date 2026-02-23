using System;
using System.IO;

namespace WordOfTheDay
{
    internal class Program
    {
        static void Main()
        {
            int choice = Menu();

            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        AppendToFile();
                        break;

                    case 2:
                        ReadFile();
                        break;

                    case 3:
                        ReadToArray();
                        break;

                    case 4:
                        try
                        {
                            string path = "Words.txt";
                            if (File.Exists(path))
                            {
                                File.Delete(path);
                                Console.WriteLine("File deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("File does not exist.");
                            }
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }
                        break;
                }

                choice = Menu();
            }
        }

        static int Menu()
        {
            Console.WriteLine("\nEnter your choice:");
            Console.WriteLine("1. Add Word");
            Console.WriteLine("2. Read All");
            Console.WriteLine("3. Read Current Word");
            Console.WriteLine("4. Delete File");
            Console.WriteLine("5. Exit");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }

            return choice;
        }

        static void AppendToFile()
        {
            string path = "Words.txt";

            Console.WriteLine("Enter the word of the day:");
            string newString = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(newString))
            {
                Console.WriteLine("Please enter a valid word:");
                newString = Console.ReadLine();
            }

            newString += ":  ";

            bool addMore = true;
            int counter = 1;

            do
            {
                Console.WriteLine("Enter definition #" + counter + ":");
                string tempString = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(tempString))
                {
                    Console.WriteLine("Please enter a valid definition:");
                    tempString = Console.ReadLine();
                }

                newString += counter + ".  " + tempString + "  ";

                Console.WriteLine("Would you like to add another definition? (yes/no)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes" || answer == "y")
                {
                    counter++;
                }
                else
                {
                    newString += "\n";
                    addMore = false;
                }

            } while (addMore);

            try
            {
                File.AppendAllText(path, newString);
                Console.WriteLine("Word added successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void ReadFile()
        {
            string path = "Words.txt";

            try
            {
                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine("\nAll Words:\n" + content);
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void ReadToArray()
        {
            string path = "Words.txt";

            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);

                    if (lines.Length > 0)
                    {
                        string currentWord = lines[lines.Length - 1];
                        Console.WriteLine("\nCurrent Word:");
                        Console.WriteLine(currentWord);
                    }
                    else
                    {
                        Console.WriteLine("File is empty.");
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}