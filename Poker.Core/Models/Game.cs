

namespace Poker.Core.Models;

public class Game
{
    public Guid Id { get; set; }
    public House House { get; set; }
    public DateTime Date { get; set; }
    public List<PlayerGames> PlayerGames { get; set; }
}