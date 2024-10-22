namespace Lidl;

public class WarehouseClerk(string firstName, string lastName, int id, string key, int heightInCm) : Person(firstName, lastName, id, key)
{
    public int HeightInCm { get; set; } = heightInCm;
    
    public void Store()
    {
        Console.WriteLine($"{FirstName} {LastName} stores an item...");
    }

    public override void Work()
    {
        Console.WriteLine($"{FirstName} {LastName} works as warehouse clerk...");
    }
}