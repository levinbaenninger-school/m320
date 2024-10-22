namespace Hotel;

public class Bed(int widthInCm)
{ 
    public int WidthInCm { get; set; } = widthInCm;
    
    public void Print()
    {
        Console.WriteLine($"Bed: {WidthInCm}cm");
    }
}