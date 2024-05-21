class Program
{
    static void Main(string[] args)
    {
        NewsArticle newsArticle = new NewsArticle();

        
        Console.WriteLine("Por favor, ingrese su nombre:");
        string username = Console.ReadLine();

        Console.WriteLine("Por favor, elija una categoría de noticias (1-4):");
        Console.WriteLine("1. World");
        Console.WriteLine("2. Sports");
        Console.WriteLine("3. Business");
        Console.WriteLine("4. Science");

  
        int categoryChoice;
        while (!int.TryParse(Console.ReadLine(), out categoryChoice) || categoryChoice < 1 || categoryChoice > 4)
        {
            Console.WriteLine("Por favor, ingrese un número válido (1-4):");
        }

     
        string category;
        switch (categoryChoice)
        {
            case 1:
                category = "World";
                break;
            case 2:
                category = "Sports";
                break;
            case 3:
                category = "Business";
                break;
            case 4:
                category = "Science";
                break;
            default:
                category = "World"; 
                break;
        }

       
        User user = new User(username);

  
        user.SubscribeToCategory(category);

 
        newsArticle.RegisterObserver(user);

      
        newsArticle.SendArticles(category);
    }
}
