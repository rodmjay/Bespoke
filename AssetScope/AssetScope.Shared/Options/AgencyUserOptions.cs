using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Options;

public class AgencyUserOptions
{
    public string UserId { get; set; } = null!;
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public List<AgencyRoleEnum> Roles { get; set; } = new();
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
}