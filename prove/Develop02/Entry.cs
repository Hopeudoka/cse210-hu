public class Entry
{
    // Create and assign variables
    public string _date;
    public string _promptText;
    public string _entryText;

    // create method
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}
