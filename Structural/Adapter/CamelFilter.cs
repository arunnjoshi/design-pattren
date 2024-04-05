using Adapter.pkg;

namespace Adapter;

public class CamelFilter : IFilter
{
    private readonly Camel carmel;

    public CamelFilter(Camel carmel)
    {
        this.carmel = carmel;
    }
    public void Apply(Image image)
    {
        carmel.Initialize();
        carmel.Render(image);
    }
}