namespace StrategyPattern;

public class ImageStorage
{
    public static void Store(string fileName, ICompressor compressor, IFilter filter)
    {
        compressor.Compress(fileName);
        filter.ApplyFilter(fileName);
    }
}
