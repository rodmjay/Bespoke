namespace AssetScope.Shared.Interfaces;

public interface IDistributionEmail
{
    int DistributionEmailId { get; set; }
    string Email { get; set; }
    int DistributionListId { get; set; }
}