using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random magic number between 1 and 100
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

            // Loop until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }

            // Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}