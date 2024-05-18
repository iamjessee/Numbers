﻿class Program
{
    static void Main(string[] args)
    {
        // Creates a list that can store multiple data types
        List<object> numbers = new List<object>();
        bool keepAdding = true;

        while (keepAdding)
        {
            // Prompts user to enter their number
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Attempts to verify user typed a valid number and adds it to list for display
            if (int.TryParse(userInput, out int intValue))
            {
                numbers.Add(intValue); // Stores as int
            }
            else if (double.TryParse(userInput, out double doubleValue))
            {
                numbers.Add(doubleValue); // Store as double
            }
            else if (float.TryParse(userInput, out float floatValue))
            {
                numbers.Add(floatValue); // Store as float
            }
            else if (long.TryParse(userInput, out long longValue))
            {
                numbers.Add(longValue); // Store as long
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
                continue; // Go to the start of the loop to re-prompt the number
            }

            // Prompts the user if they would like to keep adding more numbers 
            Console.WriteLine("Would you like to enter another number (Y/N)?");
            string userResponse = Console.ReadLine();

            if (userResponse.ToUpper() != "Y")
            {
                keepAdding = false;
            }
        }

        // displays numbers entered by user
        Console.WriteLine("Here are your numbers: ");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}