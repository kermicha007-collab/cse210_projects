using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Romans", 8, 18);
        Scripture scripture = new Scripture(reference, "For I consider that the sufferings of this present time are not worth comparing with the glory that is going to be revealed to us.");
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("\nPress Enter to continue, or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input.ToLower() != "quit" && !scripture.AllWordsHidden())
        {
            scripture.HideRandomWord(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue, or type 'quit' to exit.");
            input = Console.ReadLine();
        }

      
      
    }
}