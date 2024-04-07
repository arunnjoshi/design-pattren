namespace Flyweight;

public class PointIconFactory
{
	private Dictionary<PointType, PointIcon> icons = [];

	public PointIcon GetPointIcon(PointType type)
	{
		if (icons.TryGetValue(type, out PointIcon? value))
		{
			return value;
		}
		else
		{
			var icon = new PointIcon(type, null);
			icons[type] = icon;
			return icon;
		}
	}
}
