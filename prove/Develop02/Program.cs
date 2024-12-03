using System;

// Exceeding Requirements:
// This program allows users to track their mood before and after each journal entry. 
// At the start and end of every entry, users are asked how they feel, and these 
// moods are recorded and saved along with the entry. This addition makes journaling 
// more personal and helps users reflect on their emotions as they write.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");


        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("How are you feeling right now? (e.g., happy, sad, excited)");
                string moodBefore = Console.ReadLine();

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.WriteLine("How are you feeling after writing? (e.g., calm, relieved, thoughtful)");
                string moodAfter = Console.ReadLine();

                Entry newEntry = new Entry(prompt, response, moodBefore, moodAfter);
                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to load: ");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to save: ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}