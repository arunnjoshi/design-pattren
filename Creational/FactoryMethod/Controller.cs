namespace FactoryMethod;

public class Controller
{
	public void Render(string viewName, Dictionary<string, object> context)
	{
		var engine = CreateEngine();
		var html = engine.Render(viewName, context);
		Console.WriteLine(html);
	}

	protected virtual IViewEngineBase CreateEngine()
	{
		return new MachaViewEngine();
	}
}
