namespace Football;

public class Match(Team team1, Team team2)
{
    public Team Team1 { get; } = team1 ?? throw new ArgumentException("Match must have a valid Team 1");
    public Team Team2 { get; } = team2 ?? throw new ArgumentException("Match must have a valid Team 2");
    public Result Result { get; private set; } = new Result();

    public void PlayMatch()
    {
        Console.WriteLine($"Match between {Team1.Name} and {Team2.Name} has started!");

        var team1Goals = Team1.Play();
        var team2Goals = Team2.Play();

        var result = new Result(this, team1Goals, team2Goals);
        result.DisplayResult();
    }
}