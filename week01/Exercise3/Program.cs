using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);

        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);

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
            Console.WriteLine("You guessed it!");
        }

    }
}