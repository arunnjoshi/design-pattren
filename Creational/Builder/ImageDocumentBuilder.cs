namespace Builder;

public class ImageDocumentBuilder : IPresentationBuilder
{
	readonly ImageDocument image = new();

	public void AddSlide(Slide slide)
	{
       image.AddPage(slide.GetText());
    }
}
