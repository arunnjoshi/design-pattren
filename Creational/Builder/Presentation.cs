namespace Builder;

public class Presentation
{
	private readonly List<Slide> slides = new List<Slide>();

	public void AddSlide(Slide slide)
	{
		slides.Add(slide);
	}

	public void Export(IPresentationBuilder builder)
	{
		builder.AddSlide(new Slide("copyright"));	
		foreach (var slide in slides)
		{
			builder.AddSlide(slide);
		}
	}
}
