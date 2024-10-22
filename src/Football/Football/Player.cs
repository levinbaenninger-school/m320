namespace Football;

public class Player(string name)
{
    public string Name { get; } = name;

    public void Shoot()
    {
        Console.WriteLine($"{Name} shoots on the goal!");
    }

    public void Tackle()
    {
        Console.WriteLine($"{Name} tackles the opponent!");
    }

    public void Dribble()
    {
        Console.WriteLine($"{Name} dribbles the ball!");
    }
}