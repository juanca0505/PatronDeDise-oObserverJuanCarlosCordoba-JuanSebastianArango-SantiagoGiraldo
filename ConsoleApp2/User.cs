using System;
using System.Collections.Generic;

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

    public void Update(Article article)
    {
        if (subscribedCategories.Contains(article.Category))
        {
            Console.WriteLine($"{Name} ha sido notificado(a) sobre el nuevo artículo: {article.Title}");
        }
    }
}
