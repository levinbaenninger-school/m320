namespace Football;

public class Goalkeeper(string name)
{
    public string Name { get; } = name;

    public void Save()
    {
        Console.WriteLine($"{Name} saves the ball!");
    }

    public void GoalKick()
    {
        Console.WriteLine($"{Name} kicks the ball!");
    }
}