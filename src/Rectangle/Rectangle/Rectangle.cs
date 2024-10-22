namespace Rectangle;

public class Rectangle
{
	public Guid Id { get; } = Guid.NewGuid();
	public string Name { get; set; } = null!;
	public double Length { get; set; }
	public double Width { get; set; }
	public Point Position { get; private set; }
	public static int AngleSum { get; } = 360;
	public double Perimeter
	{
		get
		{
			return 2 * (Length + Width);
		}
	}

	public Rectangle()
	{
		Length = 0;
		Width = 0;
		Position = new Point();
	}

	public Rectangle(double length, double width) : this()
	{
		Length = length;
		Width = width;
	}

	public void Draw()
	{
		Console.WriteLine($"Rectangle with length {Length} and width {Width} at position ({Position.X}, {Position.Y})");
	}

	public void Move(double dx, double dy) => Position.Move(dx, dy);

	public void Scale(double fa, double fb)
	{
		Length *= fa;
		Width *= fb;
	}

	public double Area() => Length * Width;
}
