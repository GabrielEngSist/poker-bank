

namespace Poker.Core.Models;

public class Player
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Buyins { get; set; }
    public int Wins { get; set; }
    public int BankRoll { get; set; }
}