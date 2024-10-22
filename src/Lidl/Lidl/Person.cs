namespace Lidl;

public abstract class Person(string firstName, string lastName, int id, string key)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    protected int Id { get; private set; } = id;
    private string _key = key;

    public virtual void Eat()
    {
        Console.WriteLine($"{FirstName} {LastName} eats...");
    }
    
    public abstract void Work();
}