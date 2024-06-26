﻿namespace Flyweight;

public class Point
{
    private readonly int x;
    private readonly int y;
	private readonly PointIcon pointIcon;

	public Point(int x, int y, PointIcon pointIcon)
    {
        this.x = x;
        this.y = y;
		this.pointIcon = pointIcon;
	}

    public void Draw()
    {
        Console.WriteLine($"{pointIcon.GetPointType()} at ({x},{y})");
    }
}
