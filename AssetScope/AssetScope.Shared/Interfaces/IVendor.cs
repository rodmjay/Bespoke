using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface IVendor
{
    int Id { get; set; }
    int ContractItemId { get; set; }
    string? Justification { get; set; }
    VendorMethod VendorMethod { get; set; }
    string? Name { get; set; }
    string? BidderNumber { get; set; }
    string? FirstName { get; set; }
    string? LastName { get; set; }
    string? Position { get; set; }
    string? Email { get; set; }
    string? Phone { get; set; }
}