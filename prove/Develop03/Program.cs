using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture with multiple verses
        var reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        
        // Create a Scripture object
        var scripture = new Scripture(reference, text);

        while (true)
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user for input
            Console.WriteLine("\nPress Enter to hide random words, or type 'quit' to exit:");
            string userInput = Console.ReadLine().Trim();

            if (userInput.ToLower() == "quit")
            {
                // Exit the program
                break;
            }

            // Hide some random words if user just pressed Enter
            if (userInput == "")
            {
                scripture.HideRandomWords(3); // Hide 3 random words

                // Check if the scripture is completely hidden
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nAll words are now hidden. Program will exit.");
                    break;
                }
            }
        }
    }
}