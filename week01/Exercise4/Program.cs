using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create list
        List<int> numbers = new List<int>();

        // Output
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Input loop
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Input
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            // Add to list if not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Average
        double average = (double)sum / numbers.Count;

        // Max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Output
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // ===== STRETCH CHALLENGES =====

        // Smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}