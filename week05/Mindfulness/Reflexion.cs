public class Reflexion : Activity
{
    public Reflexion(string name, string description, int duration) : base(name, description, duration)
    {
    }
    
    private List<string> GetReflectionPrompts()
    {
        return new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Reflect on a moment when you felt truly happy.",
            "Consider a time when you helped someone in need.",
            "Think about a personal goal you achieved.",
            "Reflect on a time when you had to make a difficult decision."
        };
    }

    private List<string> GetReflectionQuestions()
    {
        return new List<string>
        {
            "What did you learn from this experience?",
            "How did this experience shape who you are today?",
            "What strengths did you discover about yourself?",
            "How can you apply what you learned to future situations?",
            "What would you do differently if faced with a similar situation?"
        };
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = GetReflectionPrompts();
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public string GetRandomQuestion()
    {
        List<string> questions = GetReflectionQuestions();
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }

    public void StartReflexionActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(5000); // Simulate reflection for 5 seconds
        Console.WriteLine(GetRandomQuestion());
        Thread.Sleep(5000); // Simulate reflection for 5 seconds
        DisplayEndingMessage();
    }
}