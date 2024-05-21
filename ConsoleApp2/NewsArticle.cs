using System;
using System.Collections.Generic;
public class NewsArticle : Subject
{
    public List<Article> articles = new List<Article>();
    public NewsArticle(string title, string category)
    {

        articles.Add(new Article(title, category));
    }

    public NewsArticle()
    {
        articles.Add(new Article("Noticias de última hora: ¡Gran terremoto!", "World"));
        articles.Add(new Article("Nuevas actualizaciones en la economía mundial", "Business"));
        articles.Add(new Article("Resultados del último partido: ¡Equipo local gana!", "Sports"));
        articles.Add(new Article("Descubrimientos emocionantes en la exploración espacial", "Science"));
    }

    public void SendArticles(string category)
    {
        foreach (var article in articles)
        {
            if (article.Category == category)
            {
                NotifyObservers(article);
            }
        }
    }

}
