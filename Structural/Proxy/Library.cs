namespace Proxy;

public class Library
{
	public Dictionary<string, IEBook> eBooks = [];
	public void Add(IEBook eBook)
	{
		eBooks.Add(eBook.GetFilename(), eBook);
	}

	public void OpenEBook(string fileName)
	{
		if(eBooks.TryGetValue(fileName, out IEBook? value))
		{
			var eBook = value;
			eBook.Show();
		}
	}
}
