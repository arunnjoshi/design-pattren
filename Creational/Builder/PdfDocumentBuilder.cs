
namespace Builder;

public class PdfDocumentBuilder : IPresentationBuilder
{
	readonly PdfDocument PdfDocument = new();

	public void AddSlide(Slide slide)
	{
		PdfDocument.AddPage(slide.GetText());
	}

	public PdfDocument GetPdfDocument()
	{
		return PdfDocument;
	}
}
