public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by focusing on your breath.", 0)
    {
    }
  
    public void StartBreathingActivity()
    {
        Console.WriteLine("Breathe in...");
        Thread.Sleep(1000); // Simulate breathing in for 1 second
        Console.WriteLine("5");
        Thread.Sleep(1000); // Simulate breathing in for 1 second
        Console.WriteLine("4");
        Thread.Sleep(1000); // Simulate breathing in for 1 second
        Console.WriteLine("3");
        Thread.Sleep(1000); // Simulate breathing in for 1 second
        Console.WriteLine("2");
        Thread.Sleep(1000); // Simulate breathing in for 1 second
        Console.WriteLine("1");
        Thread.Sleep(1000); // Simulate breathing in for 1 second
        Console.WriteLine("Breathe out...");
        Thread.Sleep(1000); // Simulate breathing out for 1 seconds
        Console.WriteLine("5");
        Thread.Sleep(1000); // Simulate breathing out for 1 seconds
        Console.WriteLine("4");
        Thread.Sleep(1000); // Simulate breathing out for 1 seconds
        Console.WriteLine("3");
        Thread.Sleep(1000); // Simulate breathing out for 1 seconds
        Console.WriteLine("2");
        Thread.Sleep(1000); // Simulate breathing out for 1 seconds
        Console.WriteLine("1");
        Thread.Sleep(1000); // Simulate breathing out for 1 seconds
    }
}