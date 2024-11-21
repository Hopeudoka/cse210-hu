public class PromptGenerator
{
    // create and assign a list to avariable
    public List<string> _prompts = new List<string>();
    
    public Random _random = new Random();

    // Create functions
    public string GetRandomPrompt()
    {

        int randomIndex = _random.Next(_prompts.Count);

        string randomPrompt = _prompts[randomIndex];
        
        return randomPrompt;
    }
}