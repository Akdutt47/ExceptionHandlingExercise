using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1) Create a char[] with 6 numbers and 3 letters
        char[] arr = { '1', '2', '3', 'a', '4', 'b', '5', '6', 'c' };
        
        // 2) Create a list called numbers that will hold integers
        List<int> numbers = new List<int>();

        // 3) Create a string variable with an empty string initializer
        string str = string.Empty;

        // 4) Make a foreach loop to iterate through your character array            
        foreach (var character in arr)
        {
            try
            {
                // 6) Inside the try block: Set your string variable to each array element
                str = character.ToString();

                // 7) Now, using int.Parse, parse your string variable
                int parsedNumber = int.Parse(str);

                // 8) Add the parsed integer to the numbers list
                numbers.Add(parsedNumber);
            }
            catch (FormatException) // 10) Inside the catch block: Handle format exceptions
            {
                // 11) Print a message if parsing fails (if character is a letter)
                Console.WriteLine($"Unable to Parse '{character}'");
            }
        }

        // Uncomment the code below to see the numbers you successfully added to the numbers list:
        foreach (var num in numbers)
        {
            Console.WriteLine(num);  // Output: 1, 2, 3, 4, 5, 6 (only the numbers)
        }
    }
}

