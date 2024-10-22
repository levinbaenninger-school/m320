namespace Lidl;

public class Child(string firstName, string lastName, int id, string key, int age) : Person(firstName, lastName, id, key)
{
    public int Age { get; set; } = age;

    public override void Eat()
    {
        Console.WriteLine($"{FirstName} {LastName} eats candy with it's hands...");
    }

    public override void Work()
    {
        Console.WriteLine($"{FirstName} {LastName} is too young to work...");
    }
}