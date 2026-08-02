using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Menu menu = new Menu();
        menu.Display();

        string input = Console.ReadLine();
        // Get duration from an Activity instance (GetDuration is not static)
        int duration;
        var tempActivity = Activator.CreateInstance(typeof(Activity), new object[] { "Temp", "", 0 });
        duration = (int)typeof(Activity).GetMethod("GetDuration").Invoke(tempActivity, null);
        if (input == "1")
        {
            Activity breathingActivity = new Activity("Breathing", "This activity will help you relax by focusing on your breath.", duration);
            breathingActivity.DisplayStartingMessage();
            // Simulate the activity duration
            System.Threading.Thread.Sleep(breathingActivity._duration * 1000);
            Breathing breathing = new Breathing("Breathing", "This activity will help you relax by focusing on your breath.", duration);
            while (duration > 0)
            {
                breathing.StartBreathingActivity();
                duration -= 10; // Each breathing cycle takes 10 seconds (5 in + 5 out)
            }
            breathingActivity.DisplayEndingMessage();
        }
        else if (input == "2")
        {
            Activity reflectionActivity = new Activity("Reflection", "This activity will guide you through a reflection exercise.", duration);
            reflectionActivity.DisplayStartingMessage();
            // Simulate the activity duration
            System.Threading.Thread.Sleep(reflectionActivity._duration * 1000);
            reflectionActivity.DisplayEndingMessage();
        }
        else if (input == "3")
        {
            Activity listingActivity = new Activity("Listing", "This activity will help you list things that bring you joy.", duration);
            listingActivity.DisplayStartingMessage();
            // Simulate the activity duration
            System.Threading.Thread.Sleep(listingActivity._duration * 1000);
            listingActivity.DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("Invalid option selected.");
        }
    }
}

