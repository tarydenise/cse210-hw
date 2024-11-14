using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;
        List<int> numbers = new List<int>();
        int count = 0;
        
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string numText = Console.ReadLine();
            userNumber = int.Parse(numText);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                count++;
            }
        }

        int sum = 0;
        int largest = numbers[0];
        int smallest = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largest)
            {
                largest = num;
            }

            if (num < smallest && num > 0)
            {
                smallest = num;
            }
        }

        double average = (double)sum / count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }    
}