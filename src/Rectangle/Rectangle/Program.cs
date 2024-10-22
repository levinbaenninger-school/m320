using System.Drawing;

namespace Rectangle;

public class Program
{
	public static void Main()
	{
		Rectangle rectangle = new(10, 5);
		rectangle.Draw();

		rectangle.Move(5, 5);
		rectangle.Draw();

		Triangle triangleOne = new();
		triangleOne.Draw();

		Triangle triangleTwo = new("Triangle Two");
		triangleTwo.Draw();

		Triangle triangleThree = new("Triangle Three", Color.Red);
		triangleThree.Draw();

		Triangle triangleFour = new("Triangle Four", Color.Blue, new Point(0, 0), new Point(0, 5), new Point(5, 0));
		triangleFour.Draw();

		Triangle triangleFive = new()
		{
			Name = "Elizabeth"
		};
		triangleFive.Draw();

		Console.ReadKey();
	}
}
