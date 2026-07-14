
using System.Collections.Generic;

public class PromptGenerator
{
    List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What is your favorite childhood memory?");
        _prompts.Add("If you could have dinner with anyone, who would it be?");
        _prompts.Add("What is something you've always wanted to try but haven't yet?");
        _prompts.Add("Describe a time when you overcame a challenge.");
        _prompts.Add("What is your favorite book or movie and why?");
        _prompts.Add("If you could travel anywhere in the world, where would you go?");

    }

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(0, _prompts.Count)];
    }

}