public class Reference
{
    // Add variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Add constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Add methods
    public string GetDisplayText()
    {
        return _endVerse == 0
            ? $"{_book} {_chapter}:{_verse}"
            : $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}