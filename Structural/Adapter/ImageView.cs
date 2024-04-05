namespace Adapter;

public class ImageView
{
    private Image image;
    public ImageView(Image image)
    {
        this.image = image;
    }
    public void Apply(IFilter filter)
    {
        filter.Apply(image);
    }
}