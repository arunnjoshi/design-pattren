namespace StrategyPattern;

public class PngCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"compressing Png {fileName} image");
    }
}
