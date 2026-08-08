public class Listing : Activity
{
    public Listing() : base("Listing", "This activity will help you list items related to a specific topic.", 0)
    {
    }

    private List<string> GetListingPrompts()
    {
        return new List<string>
        {
            "List as many fruits as you can.",
            "List your favorite hobbies.",
            "List the countries you want to visit.",
            "List the books you've read this year.",
            "List the skills you want to learn."
        };
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = GetListingPrompts();
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void StartListingActivity()
    {
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.WriteLine(GetRandomPrompt());
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            currentTime = DateTime.Now;
        }
        
        
    }
}