namespace Decorator;

public class CompressCloudStream : IStream
{
    private readonly IStream stream;

    public CompressCloudStream(IStream stream)
    {
        this.stream = stream;
    }

    public void Write(string data)
    {
        var compressedData = CompressData(data);
        stream.Write(compressedData);
    }

    private string CompressData(string data)
    {
        data += " compress ";
        return data;
    }
}