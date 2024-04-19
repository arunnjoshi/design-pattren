namespace FactoryMethod;

public class SharpController : Controller
{
	protected override IViewEngineBase CreateEngine()
	{
		return new SharpViewEngine();
	}
}
