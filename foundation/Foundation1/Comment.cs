public class Comment
{
    // Add attributes
    public string _authorName;
    public string _commentText;

    // Add methods
    public Comment(string authorName, string commentText)
    {
        _authorName = authorName;
        _commentText = commentText;
    }

    public override string ToString()
    {
        return $"{_authorName}: {_commentText}";
    }
}