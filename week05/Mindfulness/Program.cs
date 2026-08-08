using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Menu menu = new Menu();
        menu.Display();
        string input = Console.ReadLine();
        
        if (input == "1")
        { 
            Activity activity = new Activity("", "", 0);
            int duration = activity.GetDuration();
            Activity breathingActivity = new Activity("Breathing", "This activity will help you relax by focusing on your breath.", duration);
            breathingActivity.DisplayStartingMessage();
            breathingActivity.Animation();

            Breathing breathing = new Breathing();
            while (duration > 0)
            {
                breathing.StartBreathingActivity();
                duration -= 10; // Each breathing cycle takes 10 seconds (5 in + 5 out)
            }
            breathingActivity.DisplayEndingMessage();
            
        }
        else if (input == "2")
        {
            Activity activity = new Activity("", "", 0);
            int duration = activity.GetDuration();
            Activity reflectionActivity = new Activity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration);
            reflectionActivity.DisplayStartingMessage();
            reflectionActivity.Animation();
            
            Reflexion reflexion = new Reflexion();
            reflexion.StartReflexionActivity();

            reflectionActivity.DisplayEndingMessage();
        }
        else if (input == "3")
        {
            Activity activity = new Activity("", "", 0);
            int duration = activity.GetDuration();
            Activity listingActivity = new Activity("Listing", "This activity will help you list items related to a specific topic", duration);
            listingActivity.DisplayStartingMessage();
            
            Listing listing = new Listing();
            listing.StartListingActivity();
        
            listingActivity.DisplayEndingMessage();
        }
        else if (input == "4")
        {
            Console.WriteLine("Exiting the program. Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid option selected.");
        }
    }
}

