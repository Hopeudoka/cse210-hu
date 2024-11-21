using System;
using System.IO;

class Program
{
    static Journal journal1 = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int responseNum1 = ResponseFunc();


        while (responseNum1 != 5)
        {
            // create a loop to handle the user response
            if (responseNum1 == 1)
            {
                PromptGen();
                EntryFunc();

                Console.WriteLine("");
                responseNum1 = ResponseFunc();
            }
            else if (responseNum1 == 2)
            {
                DisplayFunc();

                Console.WriteLine("");
                responseNum1 = ResponseFunc();
            }
            else if (responseNum1 == 3)
            {
                LoadFileFunc();
                
                Console.WriteLine("");
                responseNum1 = ResponseFunc();
            }
            else if (responseNum1 == 4)
            {
                SaveFileFunc();

                Console.WriteLine("");
                responseNum1 = ResponseFunc();
            }
        }  
    }

    static void LoadFileFunc()
    {
        Console.WriteLine("What is the filename? ");
        string name = Console.ReadLine();

        journal1.LoadFromFile(name);
    }

    static void SaveFileFunc()
    {
        Console.WriteLine("What is the filename? ");
        string name = Console.ReadLine();

        journal1.SaveToFile(name);
    }

    static int ResponseFunc()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string response = Console.ReadLine();
        int responseNum = int.Parse(response);

        return responseNum;
    }

    static void DisplayFunc()
    {
        journal1.DisplayAll();
    }

    static string PromptGen()
    {
        // create an instance of the PromptGenerator class
        PromptGenerator prompt1 = new PromptGenerator();

        // Create a new list from the class
        prompt1._prompts = new List<string>();

        // Add to the list
        prompt1._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt1._prompts.Add("What was the best part of my day?");
        prompt1._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt1._prompts.Add("What was the strongest emotion I felt today?");
        prompt1._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompt1._prompts.Add("What would I love to remember most about today?");

        string ranPrompt = prompt1.GetRandomPrompt();

        return ranPrompt;
    }

    static void EntryFunc()
    {
        string _promptMessage = PromptGen();
        Console.WriteLine(_promptMessage);

        Entry entry1 = new Entry();

        entry1._date = DateTime.Now.ToString();

        entry1._promptText = _promptMessage;

        Console.Write("> ");
        entry1._entryText = Console.ReadLine();

        entry1.Display();

        // save entry to entry list
        journal1.AddEntry(entry1);
    }

    
}