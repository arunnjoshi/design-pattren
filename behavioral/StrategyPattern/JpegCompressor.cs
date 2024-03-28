namespace StrategyPattern;

public class JpegCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"compressing Jpeg {fileName} image");
    }
}
