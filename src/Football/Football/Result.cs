namespace Football;

public class Result
{
    public int Team1Goals { get; }
    public int Team2Goals { get; }

    public Result(Match match, int team1Goals, int team2Goals)
    {
        if (team1Goals < 0 || team2Goals < 0)
        {
            throw new ArgumentException("Goals must be a positive number");
        }
        
        Team1Goals = team1Goals;
        Team2Goals = team2Goals;
    }

    public void DisplayResult()
    {
        Console.WriteLine($"Result of the match between {Match.Team1.Name} and {Match.Team2.Name}:");
        Console.WriteLine($"{Match.Team1.Name} {Team1Goals} - {Team2Goals} {Match.Team2.Name}");
    }
}