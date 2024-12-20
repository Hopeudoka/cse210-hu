public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore = 0;

    public void AddGoal(Goal goal) // You need this method to add a goal
    {
        _goals.Add(goal);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's current score: {_totalScore}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");  // Corrected from ShortName to Name
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public int GoalsCount => _goals.Count; 

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter Goal Type (1: Simple, 2: Eternal, 3: Checklist):");
        if (!int.TryParse(Console.ReadLine(), out int goalType) || goalType < 1 || goalType > 3)
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points.");
            return;
        }

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else
        {
            Console.Write("Enter Target Count: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid target count.");
                return;
            }
            Console.Write("Enter Bonus Points: ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Invalid bonus points.");
                return;
            }
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select Goal to Record Event (number): ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        var goal = _goals[index - 1];
        goal.RecordEvent();
        _totalScore += goal.Points;

        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
            // Award bonus points once for completing the goal
            if (checklistGoal.IsComplete())
            {
                _totalScore += checklistGoal.Bonus;
                Console.WriteLine($"Bonus awarded: {checklistGoal.Bonus} points!");
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter file name to save goals: ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_totalScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter file name to load goals: ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            _totalScore = int.Parse(reader.ReadLine());
            _goals.Clear();

            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine().Split('|');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (goalType == "SimpleGoal")
                {
                    var goal = new SimpleGoal(name, description, points);
                    if (bool.Parse(parts[4])) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++) checklistGoal.RecordEvent();
                    _goals.Add(checklistGoal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}