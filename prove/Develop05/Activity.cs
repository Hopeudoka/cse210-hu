public abstract class Activity
{
    // Add Variables
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // Add methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine("How long, in seconds, would you like this activity to last?");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < _duration; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public abstract void Run();
}