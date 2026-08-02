public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void StartBreathingActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine("Breathe in...");
        Thread.Sleep(5000); // Simulate breathing in for 5 seconds
        Console.WriteLine("Breathe out...");
        Thread.Sleep(5000); // Simulate breathing out for 5 seconds
        DisplayEndingMessage();
    }
}