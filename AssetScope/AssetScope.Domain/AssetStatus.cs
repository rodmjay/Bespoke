namespace AssetScope.Domain;

public class AssetStatus
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Asset> Assets { get; set; }
}