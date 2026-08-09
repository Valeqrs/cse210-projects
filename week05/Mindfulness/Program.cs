using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // added a 4th activity gratitude and a session log

        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            {"Breathing", 0},
            {"Reflection", 0},
            {"Listing", 0},
            {"Gratitude", 0}
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity (exceeds!)");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activityLog["Breathing"]++;
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activityLog["Reflection"]++;
                    break;
                case "3":
                    activity = new ListingActivity();
                    activityLog["Listing"]++;
                    break;
                case "4":
                    activity = new GratitudeActivity();
                    activityLog["Gratitude"]++;
                    break;
                case "5":
                    Console.WriteLine("\n--- session summary ---");
                    foreach (var entry in activityLog)
                    {
                        if (entry.Value > 0)
                            Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
                    }
                    Console.WriteLine("thank you for being mindful. goodbye!");
                    return;
                default:
                    Console.WriteLine("invalid choice. press enter to try again.");
                    Console.ReadLine();
                    continue;
            }

            if (activity != null)
            {
                activity.Run();
            }
        }
    }
}