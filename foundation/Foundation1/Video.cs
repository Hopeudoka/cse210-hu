public class Video
{
    // Add attributes
    public string _title;
    public string _author;
    public int _length;
    // create lists
    public List<Comment> _comment = new List<Comment>();

    // Add constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Add methods
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comment.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_title} by {_author}, Length: {_length} Seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var comment in _comment)
        {
            Console.WriteLine($" - {comment}");
        }
    }
}