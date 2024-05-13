

namespace Poker.Data.Models;

public class PlayerGame
{
    public Guid Id { get; set; }
    public Player Player { get; set; }
    public decimal Buyins { get; set; }
    public decimal Wins { get; set; }
}