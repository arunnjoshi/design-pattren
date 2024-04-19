namespace FactoryMethod;

public class SharpViewEngine : IViewEngineBase
{
	public string Render(string viewName, Dictionary<string, object> context)
	{
		return "view rendered by Sharp";
	}
}
