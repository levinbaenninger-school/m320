namespace Person
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<Person> persons = [];

			Console.WriteLine(Person.GetNumberOfPersons());

			Person person1 = new();
			persons.Add(person1);
			person1.Print();

			person1.Baptize("Fritzli");
			person1.Print();

			person1.Baptize("Fritz", "Müller");
			person1.Print();

			Console.WriteLine($"Name: {person1.GetFullName()}");

			Person person2 = new("Hans");
			persons.Add(person2);
			person2.Print();
			Console.WriteLine($"Name: {person2.GetFullName()}");

			Person person3 = new("Heinrich", "Peters");
			persons.Add(person3);
			person3.Print();
			Console.WriteLine($"Name: {person3.GetFullName()}");

			Person person4 = new("Heinz", "Zentner", 1990);
			persons.Add(person4);
			person4.Print();
			Console.WriteLine($"Name: {person4.GetFullName()}");

			Person fridolin = person1;
			persons.Add(fridolin);
			fridolin.Baptize("Fridolin");
			fridolin.Print();
			person1.Print();

			foreach (Person person in persons)
			{
				person.Print();
			}

			Console.WriteLine(Person.GetNumberOfPersons());
		}
	}
}
