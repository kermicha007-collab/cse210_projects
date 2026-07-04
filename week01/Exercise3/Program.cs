using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Console.Write("What is the magic number? ");
        //string input = Console.ReadLine();
        //int magicNumber = int.Parse(input);

        //Console.Write("What is your guess? ");
       // string guessInput = Console.ReadLine();
       //int guess = int.Parse(guessInput);

       Random randomGenerator = new Random();
       int number = randomGenerator.Next(1, 11);

       int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
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