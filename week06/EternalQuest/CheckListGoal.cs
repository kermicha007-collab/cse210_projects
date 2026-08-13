public class CheckListGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public CheckListGoal(string name, string description, string points, int targetCount)
        : base(name, description, points)
    {
        _target = targetCount;
        _amountCompleted = 0;
        _bonus = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            // grant bonus or handle completion
            // ensure not to increment beyond target
            _amountCompleted = _target;
        }
    }
}