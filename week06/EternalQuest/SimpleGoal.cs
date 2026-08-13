public class SimpleGoal : Goal
{
    bool _isComplete;
    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        // Implementation for recording event specific to SimpleGoal
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        // Implementation for checking if SimpleGoal is complete
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // Implementation for getting string representation of SimpleGoal
        return "";
    }
}