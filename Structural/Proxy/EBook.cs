namespace Proxy
{
	public class EBook : IEBook
	{
		private readonly string fileName;

		public EBook(string fileName)
		{
			this.fileName = fileName;
			Load();
		}

		private void Load()
		{
			Console.WriteLine($"Loading the EBook: {fileName}.");
		}

		public void Show()
		{
			Console.WriteLine($"Showing the EBook: {fileName}.");
		}

		public string GetFilename()
		{
			return fileName;
		}
	}
}
