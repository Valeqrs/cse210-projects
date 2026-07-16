using System;

class Program
{
    static void Main(string[] args)
    {
        // Random number generator
        Random randomGenerator = new Random();

        // Game variables
        int magicNumber = 0;
        int guess = 0;
        int guessCount = 0;
        string playAgain = "yes";

        // Loop to play again
        while (playAgain == "yes" || playAgain == "y")
        {
            // Random number
            magicNumber = randomGenerator.Next(1, 101);
            guess = 0;
            guessCount = 0;

            // Output
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            // Guess loop
            while (guess != magicNumber)
            {
                // Input
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Compare
                if (guess < magicNumber)
                {
                    // Output
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    // Output
                    Console.WriteLine("Lower");
                }
                else
                {
                    // Output
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            // Input
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();
        }

        // Output
        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}