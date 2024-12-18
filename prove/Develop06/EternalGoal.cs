public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // Constructor
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