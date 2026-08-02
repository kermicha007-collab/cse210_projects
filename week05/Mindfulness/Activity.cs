public class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} for {_duration} seconds.");
        Console.WriteLine(_description);
    }

    public int GetDuration()
    {
         Console.WriteLine("For how many seconds would you like to perform the activity?");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
    }
}