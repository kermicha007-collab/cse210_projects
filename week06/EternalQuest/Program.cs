using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Your current score is: 0");
        GoalManager goalManager = new GoalManager();
        string choice = goalManager.Start();
        
        if (choice == "1")
        {
            // Create a new goal
            Console.WriteLine("The type of goal to create:");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
            Console.WriteLine("Enter the number corresponding to the goal type:");
            string goalType = Console.ReadLine();

            if (goalType == "1")
            {
                // Create a simple goal
                Console.WriteLine("Enter the name of the simple goal:");
                string goalName = Console.ReadLine();
                Console.WriteLine("Enter a description for the simple goal:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the points for completing the simple goal:");
                string points = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
                goalManager.AddGoal(simpleGoal);
            }
            else if (goalType == "2")
            {
                // Create an eternal goal
                Console.WriteLine("Enter the name of the eternal goal:");
                string goalName = Console.ReadLine();
                Console.WriteLine("Enter a description for the eternal goal:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the points for completing the eternal goal:");
                string points = Console.ReadLine();
                Console.WriteLine("Enter the target count for the eternal goal:");
                string targetCountInput = Console.ReadLine();
                int targetCount = 0;
                int.TryParse(targetCountInput, out targetCount);
                EternalGoal eternalGoal = new EternalGoal(goalName, description, points, targetCount);
                goalManager.AddGoal(eternalGoal);
            }
            else if (goalType == "3")
            {
                // Create a checklist goal
                Console.WriteLine("Enter the name of the checklist goal:");
                string goalName = Console.ReadLine();
                Console.WriteLine("Enter a description for the checklist goal:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the points for completing the checklist goal:");
                string points = Console.ReadLine();
                Console.WriteLine("Enter the target count for the checklist goal:");
                string targetCountInput = Console.ReadLine();
                int targetCount = 0;
                int.TryParse(targetCountInput, out targetCount);
                CheckListGoal checklistGoal = new CheckListGoal(goalName, description, points, targetCount);
                goalManager.AddGoal(checklistGoal);
            }
        }
        else if (choice == "2")
        {
            // List goals
            goalManager.ListGoals();
        }
        else if (choice == "3")
        {
            // Save goals (use reflection to support different GoalManager implementations)
            Console.WriteLine("What is the name of the file to save the goals to?");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(goalManager.GetType().GetField("totalPoints", BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(goalManager) ?? 0);
            }

        }
        else if (choice == "4")
        {
            // Load goals
            Console.WriteLine("What is the name of the file to load the goals from?");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else if (choice == "5")
        {
            // Record an event
            Console.WriteLine("The goals are:");
            foreach (Goal goal in goalManager.GetType().GetField("goals", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(goalManager) as List<Goal>)
            {
                Console.WriteLine(goal.GetDetails());
            }
            Console.WriteLine("Which goal did you accomplish? (Enter the number)");
            string goalNumberInput = Console.ReadLine();
            
        }
        else if (choice == "6")
        {
            // Quit
            Console.WriteLine("Thank you for playing Eternal Quest!");
        }
    }

    
}