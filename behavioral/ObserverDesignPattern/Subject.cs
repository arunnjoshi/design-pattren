namespace Observer;

public class Subject
{
    List<IObserver> observers = [];

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}
