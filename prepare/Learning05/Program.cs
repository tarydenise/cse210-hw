using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!\n");

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary() + "\n");
        
        MathAssigment mathAssigment = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssigment.GetSummary());
        Console.WriteLine(mathAssigment.GetHomeworkList() + "\n");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation() + "\n");
    }
}