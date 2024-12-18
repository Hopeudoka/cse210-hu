public class ListingActivity : Activity
{
    // Add variables
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "List things you are grateful for.",
        "List your favorite memories.",
        "List things you want to achieve."
    };

    public ListingActivity() : base("ListingActivity", "This activity will help you list things to bring focus and gratitude.") {}

    // Add methods
    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("You have a few seconds to prepare to begin listing items.");
        ShowCountDown(5);
        List<string> userList = GetListFromUser();
        Console.WriteLine($"You listed {userList.Count} items. Great job!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
         int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("Start listing your items. Press Enter after each item. Time starts now!");
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userList.Add(input);
                _count++;
            }
        }
        return userList;
    }
}