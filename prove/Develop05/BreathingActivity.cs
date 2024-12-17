using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Actvity", "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breathing.")
    {   
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
        }

        DisplayEndingMessage();
    }
}