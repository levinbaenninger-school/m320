namespace Football;

public class Team(string name, List<Player> players, Goalkeeper goalkeeper)
{
    public string Name { get; private set; } = name ?? throw new ArgumentException("A team must have a name");
    private List<Player> _players = players.Count == 10 ? players : throw new ArgumentException("A team must have 10 players");
    private Goalkeeper _goalkeeper = goalkeeper ?? throw new ArgumentException("A team must have a goalkeeper");

    /// <summary>
    /// Each play method for the players is called
    /// </summary>
    /// <returns>Random number of goals scored</returns>
    public int Play()
    {
        var random = new Random();

        _goalkeeper.Save();
        _goalkeeper.GoalKick();

        foreach (var player in _players)
        {
            player.Tackle();
            player.Dribble();
            player.Shoot();
        }
        
        var goals = random.Next(0, 4);

        return goals;
    }
}