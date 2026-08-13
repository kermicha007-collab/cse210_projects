public class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Points { get; set; }

    public Goal(string name, string description, string points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public virtual void RecordEvent()
    {
        // Implementation for recording event
    }

    public virtual bool IsComplete()
    {
        // Implementation for checking if goal is complete
        return false;
    }

    public virtual string GetDetails()
    {
        // Implementation for getting goal details
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        // Implementation for getting string representation of the goal
        return "";
    }
}