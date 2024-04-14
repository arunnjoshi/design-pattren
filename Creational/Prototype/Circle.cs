namespace Prototype;

public class Circle : IComponent
{
	private double radius;

	public double GetRadius()
	{
		return radius;
	}

	public void SetRadius(double radius)
	{
		this.radius = radius;
	}

	public void Render()
	{
		Console.WriteLine($"Rendering a circle with radius: {radius}");
	}

	public IComponent Clone()
	{
		var clone = new Circle
		{
			radius = radius
		};
		return clone;
	}
}