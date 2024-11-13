using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string playAgain;
        
        do 
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessCount = -1;
            
            Console.Write("What is your guess? ");
            string guessText = Console.ReadLine();
            int guessNumber = int.Parse(guessText);
            guessCount++;

            while (magicNumber != guessNumber)
            {
                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("Enter a new guess: ");
                guessNumber = int.Parse(Console.ReadLine());
                guessCount++;
            }

            if (magicNumber == guessNumber)
            {
                Console.WriteLine($"You guessed it in {guessCount} tries!");
            }

            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");

        if (playAgain != "yes")
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}