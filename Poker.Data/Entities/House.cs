

namespace Poker.Data.Models;

public class House
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Player> Players { get; set; }
}