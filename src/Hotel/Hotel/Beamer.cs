namespace Hotel;

public class Beamer(string name, int resolution)
{
    public string Name { get; set; } = name;
    public int Resolution { get; private set; } = resolution;

    public void Print()
    {
        Console.WriteLine($"Beamer: {Name}, {Resolution}");
    }
}