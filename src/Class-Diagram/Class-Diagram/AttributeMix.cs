namespace Class_Diagram;

public class AttributeMix
{
	public int Intake { get; set; }
	public int Expenditure { get; set; }
	public double Interest { get; set; } = 2;
	private bool _isAdmonished { get; set; }
	protected int Quantity { get; set; }
	internal string Name { get; set; } = "Meier";
	public int Balance
	{
		get
		{
			return Intake - Expenditure;
		}
	}

	public static int Year { get; }
}
