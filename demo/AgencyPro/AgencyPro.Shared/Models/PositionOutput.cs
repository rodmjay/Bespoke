namespace AgencyPro.Shared.Models;

public class PositionOutput
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<LevelOutput> Levels { get; set; }
}