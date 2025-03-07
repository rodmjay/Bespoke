namespace AssetScope.Domain;

public class Vendor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContactPerson { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public ICollection<Asset> Assets { get; set; }
}