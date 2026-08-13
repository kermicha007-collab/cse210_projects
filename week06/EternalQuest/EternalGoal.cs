public class EternalGoal : Goal
{
    int _targetCount;
    int _currentCount;

    public EternalGoal(string name, string description, string points, int targetCount)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        // Implementation for recording event specific to EternalGoal
        _currentCount++;
    }

    public override bool IsComplete()
    {
        // Implementation for checking if EternalGoal is complete
        return _currentCount >= _targetCount;
    }

    public override string GetStringRepresentation()
    {
        // Implementation for getting string representation of EternalGoal
        return "";
    }
}