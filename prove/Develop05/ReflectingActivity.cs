using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
     private List<string> _prompts = new List<string>
     {
          "Think of a time when you stood up for someone else.",
          "Think of a time when you did something really difficult.",
          "Think of a time when you helped someone in need.",
          "Think of a time when you did something truly selfless."
     };

     private List<string> _questions = new List<string>
     {
          "Why was this experience meaningful to you?",
          "How did you get started?",
          "What made this time different?",
          "What is your favorite things about this experience?",
          "What did you learn from this experience?"
     };

     private List<string> _shuffledPrompts;
     private List<string> _shuffledQuestions;
     private int _promptIndex = 0;
     private int _questionIndex = 0;

     public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times you have shown strength and resilience.")
     {
          ShufflePromptsAndQuestions();        
     }

     private void ShufflePromptsAndQuestions()
     {
          Random rand = new Random();

          _shuffledPrompts = new List<string>(_prompts);
          _shuffledQuestions = new List<string>(_questions);

          for (int i = _shuffledPrompts.Count - 1; i > 0; i--)
          {
               int j = rand.Next(i + 1);
               string temp = _shuffledPrompts[i];
               _shuffledPrompts[i] = _shuffledPrompts[j];
               _shuffledPrompts[j] = temp;
          }

          for (int i = _shuffledQuestions.Count - 1; i > 0; i--)
          {
               int j = rand.Next(i + 1);
               string temp = _shuffledQuestions[i];
               _shuffledQuestions[i] = _shuffledQuestions[j];
               _shuffledQuestions[j] = temp;
          }
     }

     private string GetNextPrompt()
     {
          string prompt = _shuffledPrompts[_promptIndex];
          _promptIndex++;

          if (_promptIndex >= _shuffledPrompts.Count)
          {
               _promptIndex = 0;
          }

          return prompt;
     }

     private string GetNextQuestion()
     {
          string question = _shuffledQuestions[_questionIndex];
          _questionIndex++;

          if (_questionIndex >= _shuffledQuestions.Count)
          {
               _questionIndex = 0;
          }

          return question;
     }

     public void Run()
     {
          DisplayStartingMessage();

          string prompt = GetNextPrompt();
          Console.WriteLine("\nConsider the following prompt:");
          Console.WriteLine($"--- {prompt} ---");
          Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
          Console.ReadLine();

          Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experiencce.");
          Console.Write("You may begin in: ");
          ShowCountDown(5);

          DateTime endTime = DateTime.Now.AddSeconds(_duration);
          while (DateTime.Now  < endTime)
          {
               string question = GetNextQuestion();
               Console.Write($"\n> {question} ");
               ShowSpinner(5);
          }

          DisplayEndingMessage();
     }
}