public class NewsArticle : Subject
{
    public string Title { get; }
    public string Category { get; }

    public NewsArticle(string title, string category)
    {
        Title = title;
        Category = category;
    }
}
