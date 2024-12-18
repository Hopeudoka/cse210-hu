public class ReflectingActivity : Activity                    
{
    // Add variables
    List<string> _prompts = new List<string>()
    {
        "Think about a time you overcame a challenge.",
        "Reflect on a moment you felt truly happy.",
        "Remember a time you helped someone in need."
    };

    List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful?",
        "What did you learn from this experience?",
        "How can you apply this experience to your life now?"
    };

    public ReflectingActivity() : base("Reflecting Activity",  "This activity will help you reflect on meaningful experiences.") {}

    // Add methods
    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("Consider the following Questions to reflect on your experience..");
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("Take a moment to think deeply about this.");
        ShowSpinner(5);
    }

    public void DisplayQuestions()
    {
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}