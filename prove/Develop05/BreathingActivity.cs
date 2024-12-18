public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax through breathing exercises.") {} 

    // Add methods
    public override void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            elapsed += 10;
        }

        DisplayEndingMessage();
    }
}