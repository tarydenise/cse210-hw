using System;

class Program
{
    static void Main(string[] args)
    {
        // SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS:
        // "Make sure no random prompts/questions are selected until they have all 
        // been used at least once in that session."
        
        Console.WriteLine("Hello Develop05 World!");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("====================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity (1-4): ");

            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        }       
    }
}