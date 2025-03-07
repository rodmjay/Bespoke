namespace AssetScope.Domain;

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public string AssetTag { get; set; }
    public string SerialNumber { get; set; }
    public int StatusId { get; set; }
    public DateTime AcquisitionDate { get; set; }
    public decimal Value { get; set; }
    public string DepreciationSchedule { get; set; }
    public DateTime? WarrantyEndDate { get; set; }
    public int LocationId { get; set; }
    public int? AssignedToId { get; set; }
    public int? VendorId { get; set; }

    public AssetCategory Category { get; set; }
    public AssetStatus Status { get; set; }
    public Location Location { get; set; }
    public Employee AssignedTo { get; set; }
    public Vendor Vendor { get; set; }
}