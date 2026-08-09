using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _remainingPrompts;
    private List<string> _remainingQuestions;

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _remainingPrompts = new List<string>(_prompts);
        _remainingQuestions = new List<string>(_questions);
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

    private string GetRandomQuestion()
    {
        if (_remainingQuestions.Count == 0) _remainingQuestions.AddRange(_questions);
        Random rand = new Random();
        int index = rand.Next(_remainingQuestions.Count);
        string item = _remainingQuestions[index];
        _remainingQuestions.RemoveAt(index);
        return item;
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Consider the following prompt:\n\n--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine();

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            ShowSpinner(5);
            Console.WriteLine();
        }
    }

    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}