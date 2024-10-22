using Football;

var playersBarcelona = new List<Player>
{
    new("Balde"),
    new("Araujo"),
    new("Kounde"),
    new("Cubarasi"),
    new("Gavi"),
    new("Olmo"),
    new("De Jong"),
    new("Lewandowski"),
    new("Raphinha"),
    new("Lamine Yamal")
};

var playersMadrid = new List<Player>
{
    new("Carvajal"),
    new("Militaõ"),
    new("Rüdiger"),
    new("Mendy"),
    new("Bellingham"),
    new("Camavinga"),
    new("Tchouaméni"),
    new("Vini Jr."),
    new("Mbappé"),
    new("Rodrygo")
};

var goalkeeperBarcelona = new Goalkeeper("Ter Stegen");
var goalkeeperMadrid = new Goalkeeper("Courtois");

var team1 = CreateTeam("FC Barcelona", playersBarcelona, goalkeeperBarcelona);
var team2 = CreateTeam("Real Madrid CF", playersMadrid, goalkeeperMadrid);

var match = new Match(team1, team2);
match.PlayMatch();

Team CreateTeam(string name, List<Player> players, Goalkeeper goalkeeper)
{
    try
    {
        return new(name, players, goalkeeper);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}