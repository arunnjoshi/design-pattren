namespace Adapter.pkg;

public class Camel
{
    public void Initialize()
    {
        Console.WriteLine("Initialize camel filter");
    }

    public void Render(Image image)
    {
        System.Console.WriteLine("applying camel filter");
    }
}