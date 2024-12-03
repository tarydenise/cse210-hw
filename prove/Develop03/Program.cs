using System;
using System.Collections.Generic;
using System.IO;

// Exceeding Requirements:
// This program loads a random scripture from the "scriptures.txt" file. This 
// provides a library of scriptures to choose from without messing with the code.
// User can also add new scriptures directly to the text file whenever they'd like.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.\n");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\n> ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(1);
        }

        Console.Clear();
        Console.WriteLine("Well done! You've memorized the scripture!");
        Console.WriteLine(scripture.GetDisplayText());
    }

    static List<Scripture> LoadScripturesFromFile(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string[] referenceParts = parts[0].Split(',');

                string book = referenceParts[0];
                int chapter = int.Parse(referenceParts[1]);
                int startVerse = int.Parse(referenceParts[2]);

                if (referenceParts.Length == 4)
                {
                    int endVerse = int.Parse(referenceParts[3]);
                    Reference reference = new Reference(book, chapter, startVerse, endVerse);
                    scriptures.Add(new Scripture(reference, parts[1]));
                }
                else
                {
                    Reference reference = new Reference(book, chapter, startVerse);
                    scriptures.Add(new Scripture(reference, parts[1]));
                }
            }
        }
        else
        {
            Console.WriteLine($"File {fileName} not found.");
        }

        return scriptures;
    }
}