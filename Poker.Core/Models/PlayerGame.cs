

namespace Poker.Core.Models;

public class PlayerGame
{
    public Guid Id { get; set; }
    public Player Player { get; set; }
    public decimal Chips { get; set; }
    public Game Game { get; set; }
}