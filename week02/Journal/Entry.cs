using System;

public class Entry
{
    // Attributes
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _mood = "";

    // Constructor
    public Entry()
    {
    }

    // Display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }
}