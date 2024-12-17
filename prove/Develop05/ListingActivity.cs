using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
   private List<string> _prompts = new List<string>
   {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
   };

    public ListingActivity() : base("Listening Activity", "This activity will help you reflect on the good things in your life by listing as many items as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("Start listing items. Press Enter after each item!");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        DisplayEndingMessage();
    }
}