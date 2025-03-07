namespace AssetScope.Domain;

public class AssetCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Asset> Assets { get; set; }
}