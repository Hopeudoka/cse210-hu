public class ChecklistGoal : Goal
{
    // Fields
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0; // Initialize completed amount
        _target = target;     // Set the target
        _bonus = bonus;       // Set the bonus points
    }

    public int Bonus => _bonus;  

    // Record an event (increment the completed amount)
    public override void RecordEvent()
    {
        if (_amountCompleted < _target) // Only increment if the goal is not yet complete
        {
            _amountCompleted++;
            Console.WriteLine($"Goal '{_shortName}' recorded! Progress: {_amountCompleted}/{_target}");

            // If goal is completed, apply the bonus
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal '{_shortName}' completed! You earned a bonus of {_bonus} points.");
            }
        }
    }

    // Check if the goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Get a detailed string representation of the goal
    public override string GetDetailsString()
    {
        return IsComplete()
            ? $"[X] {_shortName} ({_description}) - Completed {_amountCompleted}/{_target} with Bonus: {_bonus}"
            : $"[ ] {_shortName} ({_description}) - Completed {_amountCompleted}/{_target}";
    }

    // Get a concise string representation of the goal
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{Points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
