public class Journal
{
    // create a list and assign it to a variable
    public List<Entry> _entries = new List<Entry>();

    // create methods
    public void AddEntry(Entry newEntry)
    {
        // Check if the newEntry is not null
        if (newEntry != null)
        {
            _entries.Add(newEntry); 
            Console.WriteLine("Entry added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid entry. Cannot add to the journal.");
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        string journal = file;

        using (StreamWriter outputFile = new StreamWriter(journal))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}");
                outputFile.WriteLine($"Prompt: {entry._promptText}");
                outputFile.WriteLine($"Entry: {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // _entries.Clear();

        // Read all lines from the file
        string[] lines = System.IO.File.ReadAllLines(file);
        
        // Temporary variables for entry components
        string date = "";
        string promptText = "";
        string entryText = "";

        // Parse the file content
        foreach (string line in lines)
        {
            if (line.StartsWith("Date:")) // Detect date
            {
                date = line.Substring(6).Trim(); // Extract date
            }
            else if (line.StartsWith("Prompt:")) // Detect prompt text
            {
                promptText = line.Substring(8).Trim(); // Extract prompt
            }
            else if (line.StartsWith("Entry:")) // Detect entry text
            {
                entryText = line.Substring(7).Trim(); // Extract entry
            }
            else if (string.IsNullOrWhiteSpace(line)) // End of an entry
            {
            Entry newEntry = new Entry
            {
                _date = date,
                _promptText = promptText,
                _entryText = entryText
            };

            _entries.Add(newEntry);

            // Reset for the next entry
            date = "";
            promptText = "";
            entryText = "";
            }
        }
    }
}