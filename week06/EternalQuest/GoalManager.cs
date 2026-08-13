using System;
using System.Collections.Generic;

public class GoalManager
{
    List<Goal> goals = new List<Goal>();
    int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public string Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Your current score is: " + _score);
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record an event");
        Console.WriteLine("6. Quit");
        string answer = Console.ReadLine();
        return answer;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("Your goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name} - {goals[i].Description}");
        }
    }
}
