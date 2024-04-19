namespace FactoryMethod;

public class MachaViewEngine : IViewEngineBase
{
	public string Render(string viewName, Dictionary<string, object> context)
	{
		return "view rendered by Macha";
	}
}
