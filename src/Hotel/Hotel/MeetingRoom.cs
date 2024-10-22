namespace Hotel;

public class MeetingRoom
{
    private readonly int _nextNumber = 1;
    public int Number { get; set; }
    public int NumberOfSeats { get; set; }
    public List<Beamer> Beamers { get; set; }

    public MeetingRoom(int numberOfSeats, List<Beamer>? beamers = null)
    {
        Number = _nextNumber <= 3 ? _nextNumber : throw new InvalidOperationException("There can't be more than 3 meeting rooms in a hotel.");
        NumberOfSeats = numberOfSeats >= 1 ? numberOfSeats : throw new InvalidOperationException("A meeting room must have at least 1 seat.");
        Beamers = (Beamers?.Count ?? 0) <= 2 ? beamers ?? [] : throw new InvalidOperationException("There can't be more than 2 beamers in a meeting room.");
        _nextNumber++;
    }
    
    public void AddBeamer(Beamer beamer)
    {
        if (Beamers.Count > 2)
        {
            throw new InvalidOperationException("There can't be more than 2 beamers in a meeting room.");
        }
        
        Beamers.Add(beamer);
    }
    
    public void Print()
    {
        Console.WriteLine($"Meeting Room {Number} with {NumberOfSeats} seats");
        foreach (var beamer in Beamers)
        {
            Console.Write("\t");
            beamer.Print();
        }
    }
}