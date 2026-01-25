using System;

namespace tempConverter
{
    class temps
    {
        public static void Main(string[] args)
        {
            int intNumToConvert;
            double dblNumToConvert;
            bool stop = false;

            do
            {
                try
                {
                    intNumToConvert = 0;
                    dblNumToConvert = 0;

                    Console.WriteLine("Enter the temp you want converted");
                    var numberToConvert = Console.ReadLine();

                    while (!int.TryParse(numberToConvert, out intNumToConvert) &&
                           !double.TryParse(numberToConvert, out dblNumToConvert))
                    {
                        Console.WriteLine("You must enter a valid number, please try again");
                        numberToConvert = Console.ReadLine();
                    }

                    if (intNumToConvert != 0)
                        convertTemp(intNumToConvert);
                    else
                        convertTemp(dblNumToConvert);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You need to enter a number");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number you entered is too big");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to convert another temp? (Y for yes, any key for no)");
                    char more;

                    while (!char.TryParse(Console.ReadLine(), out more))
                    {
                        Console.WriteLine("Please enter a valid character, try again...");
                    }

                    if (Char.ToLower(more) != 'y')
                        stop = true;
                }

            } while (!stop);
        }

        private static void convertTemp(int intNumToConvert)
        {
            int celsius = 0;
            int fahrenheit = 0;

            try
            {
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
                celsius = (intNumToConvert - 32) * 5 / 9;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("There was a problem converting the temperature");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unknown error occurred when converting the temperature");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (celsius == 0 && fahrenheit == 0)
                {
                    Console.WriteLine("The temperature could not be converted");
                }
                else
                {
                    Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Fahrenheit is {fahrenheit}");
                    Console.WriteLine($"{intNumToConvert} degrees Fahrenheit converted to Celsius is {celsius}");
                }
            }
        }

        private static void convertTemp(double intNumToConvert)
        {
            double celsius = 0;
            double fahrenheit = 0;

            try
            {
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
                celsius = (intNumToConvert - 32) * 5 / 9;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("There was a problem converting the temperature");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unknown error occurred when converting the temperature");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (celsius == 0 && fahrenheit == 0)
                {
                    Console.WriteLine("The temperature could not be converted");
                }
                else
                {
                    Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Fahrenheit is {fahrenheit:F2}");
                    Console.WriteLine($"{intNumToConvert} degrees Fahrenheit converted to Celsius is {celsius:F2}");
                }
            }
        }
    }
}
