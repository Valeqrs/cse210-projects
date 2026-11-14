using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Attributes
    public List<string> _prompts = new List<string>();
    private List<string> _unusedPrompts = new List<string>();
    private Random _random = new Random();

    // Constructor
    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is one thing I learned today?");
        _prompts.Add("What made me smile today?");

        RefillUnusedPrompts();
    }

    // Refill and shuffle the unused prompts list
    private void RefillUnusedPrompts()
    {
        _unusedPrompts.Clear();
        _unusedPrompts.AddRange(_prompts);

        // Fisher-Yates shuffle
        for (int i = _unusedPrompts.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            string temp = _unusedPrompts[i];
            _unusedPrompts[i] = _unusedPrompts[j];
            _unusedPrompts[j] = temp;
        }
    }

    // Get a random prompt does not repeat until all have been used
    public string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            RefillUnusedPrompts();
        }

        int index = _random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return prompt;
    }
}