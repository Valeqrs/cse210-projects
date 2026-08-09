using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "What are three things you are grateful for today?",
        "Who is someone that made you smile recently?",
        "What is a simple pleasure you enjoyed today?",
        "What is a challenge you overcame that you are thankful for?"
    };
    private List<string> _remainingPrompts;

    public GratitudeActivity()
    {
        _name = "Gratitude Activity";
        _description = "This activity will help you focus on the positive aspects of your life by reflecting on things you are grateful for.";
        _remainingPrompts = new List<string>(_prompts);
    }

    private string GetRandomPrompt()
    {
        if (_remainingPrompts.Count == 0) _remainingPrompts.AddRange(_prompts);
        Random rand = new Random();
        int index = rand.Next(_remainingPrompts.Count);
        string item = _remainingPrompts[index];
        _remainingPrompts.RemoveAt(index);
        return item;
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) items.Add(input);
        }
        return items;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Reflect on the following:\n--- {prompt} ---");
        Console.Write("Take a moment to think... ");
        ShowSpinner(5);
        Console.WriteLine("\nStart listing the things you are grateful for (type each and press enter):");
        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} things you are grateful for!");
        DisplayEndingMessage();
    }
}