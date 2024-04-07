namespace Flyweight;

public class PointIcon
{
	private readonly PointType type;
	private readonly byte[]? icon;

	public PointIcon(PointType type, byte[]? icon)
	{
		this.type = type;
		this.icon = icon;
	}

	public PointType GetPointType()
	{
		return type;
	}
}
