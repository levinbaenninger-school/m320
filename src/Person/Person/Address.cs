namespace Person
{
	public class Address
	{
		public required string Street { get; set; }
		public required string PostalCode { get; set; }
		public required string City { get; set; }

		public void Print()
		{
			Console.WriteLine($"{Street}\n{PostalCode} {City}");
		}
	}
}
