using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 15.0);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}