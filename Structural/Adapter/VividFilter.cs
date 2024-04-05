namespace Adapter;

public class VividFilter : IFilter
{
    public void Apply(Image image)
    {
        Console.WriteLine("Apply vivid filter");
    }
}