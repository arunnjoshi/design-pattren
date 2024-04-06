namespace Decorator;

public class EncryptedCloudStream : IStream
{

    private readonly IStream stream;

    public EncryptedCloudStream(IStream stream)
    {
        this.stream = stream;
    }

    public void Write(string data)
    {
        var encryptDate = EncryptDate(data);
        stream.Write(encryptDate);
    }

    private string EncryptDate(string data)
    {
        return "%%1234%%";
    }
}
