namespace Proxy;

public class EBookProxy : IEBook
{
	private readonly string fileName;
	private EBook eBook;
	public EBookProxy(string fileName)
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
		eBook.Show();
	}
}
