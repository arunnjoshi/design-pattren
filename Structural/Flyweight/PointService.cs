namespace Flyweight;

public class PointService
{
	private readonly PointIconFactory _iconFactory;
	public PointService(PointIconFactory iconFactory)
	{
		_iconFactory = iconFactory;
	}
	public List<Point> GetPoints()
	{
		return
		[
			new(1, 2,_iconFactory.GetPointIcon(PointType.HOSPITAL)),
			new(2, 3,_iconFactory.GetPointIcon(PointType.CAFE)),
			new(4, 3,_iconFactory.GetPointIcon(PointType.RESTAURANT)),
		];
	}
}
