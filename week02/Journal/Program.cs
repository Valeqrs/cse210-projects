using System;

// Creativity :
// 1. Each journal entry now includes a "mood" field. The user is asked how they are feeling
//    when writing an entry. The mood is displayed with the entry and is saved to / loaded from
//    the file (as a fourth field separated by '|').
// 2. The PromptGenerator uses a shuffle-bag approach so that prompts do not repeat until
//    all prompts have been used at least once. This improves variety compared to pure random
//    selection with replacement.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            // Display menu
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("How are you feeling? (e.g., Happy, Sad, Neutral): ");
                    string mood = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    newEntry._mood = mood;

                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry saved!");
                    break;

                case "2":
                    // Display the journal
                    journal.DisplayAll();
                    break;

                case "3":
                    // Load from file
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4":
                    // Save to file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}