class Program
{
    static void Main(string[] args)
    {
        NewsArticle newsArticle = new NewsArticle("Noticias de última hora: ¡Gran terremoto!", "World");
        User user1 = new User("Alice");
        User user2 = new User("Bob");

        user1.SubscribeToCategory("World");
        user2.SubscribeToCategory("Sports");

        newsArticle.RegisterObserver(user1);
        newsArticle.RegisterObserver(user2);

        newsArticle.NotifyObservers();
    }
}
