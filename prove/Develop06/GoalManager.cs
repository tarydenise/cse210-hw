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
        // "Main" function called by Program.cs, then runs
        // the menu loop.
    }

    public void DisplayPlayerInfo()
    {
        // Displays the players current score.
    }

    public void ListGoalNames()
    {
        // Lists the names of each of the goals.
    }

    public void ListGoalDetails()
    {
        // Lists the details of each goall (including the 
        // checkbox of whether it is complete).
    }

    public void CreateGoal()
    {
        // Asks the user for the information about a new goal. 
        // Then, creates the goal and adds it to the list.
    }

    public void RecordEvent()
    {
        // Asks the user which goal they have done and then 
        // records the event by calling the RecordEvent method
        // on that goal.
    }

    public void SaveGoals()
    {
        // Saves the list of goals to a file.
    }

    public void LoadGoals()
    {
        // Loads the list of goals from a file.
    }
}