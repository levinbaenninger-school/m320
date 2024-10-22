namespace Lidl;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>();
        
        var customer = new Customer("Jane", "Doe", 1000, "KEY1000");
        var warehouseClerk = new WarehouseClerk("Jack", "Doe", 1001, "KEY1001 ", 180);
        var child = new Child("John", "Doe", 1002, "KEY1002", 10);
        
        people.Add(customer);
        people.Add(warehouseClerk);
        people.Add(child);
        
        foreach (var person in people)
        {
            person.Eat();
            person.Work();
        }
        
        Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}; {customer.Revenue};");
        Console.WriteLine($"WarehouseClerk: {warehouseClerk.FirstName} {warehouseClerk.LastName}; {warehouseClerk.HeightInCm}");
        Console.WriteLine($"Child: {child.FirstName} {child.LastName}; {child.Age}");
    }
}