namespace Proxy;

public class LoggingEBookProxy : IEBook
{
	private readonly string fileName;
	private EBook eBook;
	public LoggingEBookProxy(string fileName)
	{
		this.fileName = fileName;
	}

	public string GetFilename()
	{
		return fileName;
	}

	public void Show()
	{
		eBook ??= new EBook(fileName);
        Console.WriteLine("Logging");
        eBook.Show();
	}
}
