using System;

public class User : IObserver
{
    public string Name { get; }
    private List<string> subscribedCategories = new List<string>();

    public User(string name)
    {
        Name = name;
    }

    public void SubscribeToCategory(string category)
    {
        subscribedCategories.Add(category);
    }

    public void UnsubscribeFromCategory(string category)
    {
        subscribedCategories.Remove(category);
    }

    public void Update(Subject subject)
    {
        if (subject is NewsArticle newsArticle && subscribedCategories.Contains(newsArticle.Category))
        {
            Console.WriteLine($"{Name} ha sido notificada sobre el nuevo artículo: {newsArticle.Title}");
        }
    }
}
