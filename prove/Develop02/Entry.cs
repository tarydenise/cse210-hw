using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _moodBefore;
    public string _moodAfter;

    public Entry(string promptText, string entryText, string moodBefore, string moodAfter)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptText;
        _entryText = entryText;
        _moodBefore = moodBefore;
        _moodAfter = moodAfter;
    }

    public void Display()
    {
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood Before: {_moodBefore}");
        Console.WriteLine($"Mood After: {_moodAfter}");
        Console.WriteLine("-------------------------------------------------------------------------------------");
    }
}