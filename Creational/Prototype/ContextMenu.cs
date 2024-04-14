namespace Prototype;

public class ContextMenu
{
	public void Duplicate(IComponent component)
	{
		component.Clone();
	}
} 