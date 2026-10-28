using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guessing game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;

    
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}