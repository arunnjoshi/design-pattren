namespace FactoryMethod;

public interface IViewEngineBase
{
	public string Render(string viewName, Dictionary<string, object> context);
}