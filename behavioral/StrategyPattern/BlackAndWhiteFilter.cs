namespace StrategyPattern;

public class BlackAndWhiteFilter : IFilter
{
    public void ApplyFilter(string fileName)
    {
        Console.WriteLine($"Appling Black and white filter on {fileName}");
    }
}
