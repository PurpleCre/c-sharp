public class Video
{
    private string Title;
    private string Author;
    private int Duration;
    private List<Comment> Comments;

    public Video(string title, string author, int duration, List<Comment> comments)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = comments;
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public int GetDuration()
    {
        return Duration;
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in Comments)
        {
            Console.WriteLine(comment.GetAuthorName() + ": " + comment.GetText());
        }
    }
}