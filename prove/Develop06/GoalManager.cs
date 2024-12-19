using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                SaveGoals();
            }
            else if (choice == "5")
            {
                LoadGoals();
            }
            else if (choice == "6")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter a description: ");
        string desc = Console.ReadLine();
        Console.WriteLine("Enter the points for each event: ");
        int points = int.Parse(Console.ReadLine());

        if (typeChoice == "1")
        {
            SimpleGoal sg = new SimpleGoal(name, desc, points);
            _goals.Add(sg);
        }
        else if (typeChoice == "2")
        {
            EternalGoal eg = new EternalGoal(name, desc, points);
            _goals.Add(eg);
        }
        else if (typeChoice == "3")
        {
            Console.Write("Enter the target number of completion: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points when completed: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);
            _goals.Add(cg);
        }
        else
        {
            Console.WriteLine("Invalid goal type");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();
        Console.Write("Choice: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        Goal goal = _goals[goalIndex];

        goal.RecordEvent();

        int earnedPoints = goal.GetPoints();

        if (goal is ChecklistGoal cg)
        {
            if (cg.IsComplete() && cg.GetAmountCompleted() == cg.GetTarget())
            {
                earnedPoints += cg.GetBonus();
            }
        }

        _score += earnedPoints;

        Console.WriteLine($"You earned {earnedPoints} points! Total score is now {_score}.");
    }

    public void SaveGoals()
    {
        Console.Write("Enter a file name to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals and score saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the file name to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]);
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string data = parts[1];
            string[] dataParts = data.Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = dataParts[0];
                string desc = dataParts[1];
                int points = int.Parse(dataParts[2]);
                bool isComplete = bool.Parse(dataParts[3]);

                SimpleGoal sg = new SimpleGoal(name, desc, points);

                if (isComplete)
                {
                    sg.RecordEvent();
                }

                _goals.Add(sg);
            }
            else if (goalType == "EternalGoal")
            {
                string name = dataParts[0];
                string desc = dataParts[1];
                int points = int.Parse(dataParts[2]);

                EternalGoal eg = new EternalGoal(name, desc, points);
                _goals.Add(eg);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = dataParts[0];
                string desc = dataParts[1];
                int points = int.Parse(dataParts[2]);
                int target = int.Parse(dataParts[3]);
                int bonus = int.Parse(dataParts[4]);
                int amountCompleted = int.Parse(dataParts[5]);

                ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);
                cg.SetAmountCompleted(amountCompleted);
                _goals.Add(cg);
            }
        }

        Console.WriteLine("Goals and score laoded successfully.");
    }
}