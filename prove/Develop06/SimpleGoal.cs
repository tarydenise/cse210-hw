public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
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
}