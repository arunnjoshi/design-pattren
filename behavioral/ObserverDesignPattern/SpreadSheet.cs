namespace Observer;

public class SpreadSheet : IObserver
{
    public void Update()
    {
        Console.WriteLine("SpreadSheet got notified.");
    }
}
