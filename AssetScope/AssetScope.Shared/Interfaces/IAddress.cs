namespace AssetScope.Shared.Interfaces;

public interface IAddress
{
    string? StreetAddress { get; set; }
    string City { get; set; }
    string State { get; set; }
    string ZipCode { get; set; }
}