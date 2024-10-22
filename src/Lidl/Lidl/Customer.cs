namespace Lidl;

public class Customer(string firstName, string lastName, int id, string key) : Person(firstName, lastName, id, key)
{
    public float Revenue { get; set; } = 0;
    
    public void Buy(float amount)
    {
        Console.WriteLine($"{FirstName} {LastName} buys food for {amount:C}...");
        Revenue += amount;
    }
    
    public override void Work()
    {
        Console.WriteLine($"{FirstName} {LastName} works to be able to buy at Lidl...");
    }
}