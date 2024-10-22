namespace Rectangle;

public class Point
{
	public double X { get; set; }
	public double Y { get; set; }

	public Point()
	{
		X = 0;
		Y = 0;
	}

	public Point(double x, double y)
	{
		X = x;
		Y = y;
	}

	public void Move(double dx, double dy)
	{
		X += dx;
		Y += dy;
	}
}
