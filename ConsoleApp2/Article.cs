public class Article
{
    public string Title { get; }
    public string Category { get; }

    public Article(string title, string category)
    {
        Title = title;
        Category = category;
    }
}
