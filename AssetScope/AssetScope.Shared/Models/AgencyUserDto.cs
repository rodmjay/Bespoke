using AssetScope.Shared.Interfaces;

namespace AssetScope.Shared.Models;

public class AgencyUserDto : BaseDto, IAgencyUser
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string StateOrganizationId { get; set; } = null!;
    public string StaffType { get; set; } = null!;
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Manual { get; set; }
    public bool DOEOnly { get; set; }
}