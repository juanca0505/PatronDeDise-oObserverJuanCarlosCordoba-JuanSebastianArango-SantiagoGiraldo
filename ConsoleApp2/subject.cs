using System.Collections.Generic;
public class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(Article article)
    {
        foreach (var observer in observers)
        {
            observer.Update(article);
        }
    }
}
