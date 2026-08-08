public class Activity
{
    public string _name;
    public string _description;
    public int _duration;
    public int _animationDuration = 3; // Duration for the animation in seconds

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
    
    public void Animation()
    {
        for (int i = 0; i < _animationDuration; i++)
        {
          Console.Write("+");

          Thread.Sleep(1000);

          Console.Write("\b \b"); // Erase the + character
          Console.Write("-"); // Replace it with the - character
        }  

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