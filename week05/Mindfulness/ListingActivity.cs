using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _remainingPrompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _remainingPrompts = new List<string>(_prompts);
        _count = 0;
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
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }
        return items;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many responses as you can to the following prompt:\n--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine();

        List<string> userItems = GetListFromUser();
        _count = userItems.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
}