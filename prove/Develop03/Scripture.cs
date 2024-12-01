public class Scripture
{
    // create variables 
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Add constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ")
                     .Select(word => new Word(word))
                     .ToList();
    }

    // Add methods
    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        var random = new Random();
        visibleWords = visibleWords.OrderBy(x => random.Next()).ToList();
    
        foreach (var word in visibleWords.Take(numberToHide))
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}