public class Comment
{
    private string Text;
    private string AuthorName;

    public Comment(string text, string authorName)
    {
        Text = text;
        AuthorName = authorName;
    }

    public string GetText()
    {
        return Text;
    }

    public string GetAuthorName()
    {
        return AuthorName;
    }
}