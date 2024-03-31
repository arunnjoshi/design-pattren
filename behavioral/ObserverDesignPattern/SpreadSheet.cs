namespace Observer;

public class SpreadSheet : IObserver
{
    private DataSource _dataSource;
    public SpreadSheet(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        Console.WriteLine($"SpreadSheet got notified. value: {_dataSource.GetValue()}");
    }
}
