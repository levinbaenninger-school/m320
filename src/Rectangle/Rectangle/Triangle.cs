using System.Drawing;

namespace Rectangle
{
	public class Triangle
	{
		public string Name { get; set; } = null!;
		public Color Color { get; private set; }
		internal Point[] Points { get; private set; } = new Point[3];
		private Point Centre { get; set; } = null!;

		public Triangle()
		{
			Name = "Triangle";
			Color = Color.White;
			Points[0] = new Point();
			Points[1] = new Point();
			Points[2] = new Point();
			Centre = new Point();
		}

		public Triangle(string name) : this()
		{
			Name = name;
		}

		public Triangle(string name, Color color) : this(name)
		{
			Color = color;
		}

		public Triangle(string name, Color color, Point p1, Point p2, Point p3) : this(name, color)
		{
			Points[0] = p1;
			Points[1] = p2;
			Points[2] = p3;
			Centre = new Point((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3);
		}

		public void Draw()
		{
			Console.WriteLine($"A {Color} Triangle named {Name} at {Points[0].X} and {Points[0].Y}, {Points[1].X} and {Points[1].Y} and {Points[2].X} and {Points[2].Y} with the centre at {Math.Round(Centre.X)} and {Math.Round(Centre.Y)}");
		}

		public double CalculateCircumference()
		{
			double a = Math.Sqrt(Math.Pow(Points[1].X - Points[0].X, 2) + Math.Pow(Points[1].Y - Points[0].Y, 2));
			double b = Math.Sqrt(Math.Pow(Points[2].X - Points[1].X, 2) + Math.Pow(Points[2].Y - Points[1].Y, 2));
			double c = Math.Sqrt(Math.Pow(Points[0].X - Points[2].X, 2) + Math.Pow(Points[0].Y - Points[2].Y, 2));
			return a + b + c;
		}
	}
}
