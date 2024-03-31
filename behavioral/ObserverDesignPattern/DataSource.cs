namespace Observer;

public class DataSource : Subject
{
    private int value;
    public int GetValue()
    {
        return value;
    }

    public void SetValue(int value)
    {
        this.value = value;
        NotifyObserver();
    }
}
