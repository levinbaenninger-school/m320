namespace Hotel;

public class Room
{
    private readonly int _nextNumber = 1;
    public int Number { get; set; }
    public List<Bed> Beds { get; set; } = [];
    
    public Room()
    {
        Number = _nextNumber <= 10 ? _nextNumber : throw new InvalidOperationException("There can't be more than 10 rooms in a hotel.");
        _nextNumber++;
    }
    
    public void AddBed(Bed bed)
    {
        Beds.Add(bed);
    }
    
    public void Print()
    {
        Console.WriteLine($"Room {Number}");
        
        foreach (var bed in Beds)
        {
            Console.Write("\t");
            bed.Print();
        }
    }
}