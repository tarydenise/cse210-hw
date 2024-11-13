using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letter = "";
        int remainder = gradePercentage % 10;
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradePercentage >= 97 || gradePercentage < 60)
        {
            sign = "";
        }

        Console.WriteLine($"Current grade: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time.");
        }
    }
}