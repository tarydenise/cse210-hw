public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        return 0;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRespresentation()
    {
        return "";
    }

    public override string GetDetailsString()
    {
        return "";
    }
}