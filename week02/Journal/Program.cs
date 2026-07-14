using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
           PromptGenerator promptGenerator = new PromptGenerator();
           string prompt = promptGenerator.GetRandomPrompt();
           Console.WriteLine(prompt);
           string response = Console.ReadLine();
           Journal journal = new Journal();
           journal.AddEntry(new Entry(DateTime.Now.ToString(), prompt, response));
        }

        else if (choice == "2")
        {
            Journal journal = new Journal();
            journal.DisplayEntries();
        }
        else if (choice == "3")
        {
            Console.Write("Enter the filename to load: ");
            string filename = Console.ReadLine();
            Journal journal = new Journal();
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded successfully.");
        }
        else if (choice == "4")
        {
            Console.Write("Enter the filename to save: ");
            string filename = Console.ReadLine();
            Journal journal = new Journal();
            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved successfully.");
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
        
        

    }
}