using AssetScope.Shared.Interfaces;

namespace AssetScope.Shared.Models;

public class AddressDto : IAddress
{
    public string? StreetAddress { get; set; }
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
}