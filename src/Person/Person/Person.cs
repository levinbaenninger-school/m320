namespace Person
{
	public class Person
	{
		private static int nextId = 1;
		private static int numberOfPersons = 0;
		public int Id { get; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int YearOfBirth { get; private set; } = DateTime.Now.Year;
		public Address Address { get; set; }

		public Person()
		{
			Id = nextId++;
			FirstName = "Baby";
			LastName = "Meier";
			YearOfBirth = 2020;
			numberOfPersons++;
		}

		public Person(string firstName) : this()
		{
			FirstName = firstName;
		}

		public Person(string firstName, string lastName) : this(firstName)
		{
			LastName = lastName;
		}

		public Person(string firstName, string lastName, int yearOfBirth) : this(firstName, lastName)
		{
			YearOfBirth = yearOfBirth;
		}

		public void Print()
		{
			Console.WriteLine($"{Id}: {FirstName} {(LastName is not null ? LastName : "with no name")} was born in the year {YearOfBirth}");
		}

		public void PrintWithAddress()
		{
			Print();
			Address.Print();
		}

		public void Baptize(string firstName)
		{
			FirstName = firstName;
		}

		public void Baptize(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public string GetFullName()
		{
			return $"{FirstName} {LastName}";
		}

		public static int GetNumberOfPersons()
		{
			return numberOfPersons;
		}
	}
}
