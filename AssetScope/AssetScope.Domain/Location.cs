namespace AssetScope.Domain;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public ICollection<Asset> Assets { get; set; }
}