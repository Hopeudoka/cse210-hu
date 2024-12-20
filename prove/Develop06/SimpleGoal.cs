public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)  // Only mark as complete if it's not already complete
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points} points.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return _isComplete ? $"[X] {_shortName} ({_description})" : $"[ ] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}