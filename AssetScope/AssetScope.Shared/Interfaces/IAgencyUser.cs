namespace AssetScope.Shared.Interfaces;

public interface IAgencyUser : IUserInfo
{
    string UserId { get; set; }
    string Name { get; set; }
    string StateOrganizationId { get; set; }
    string StaffType { get; set; }
    DateTime BeginDate { get; set; }
    DateTime? EndDate { get; set; }
    bool Manual { get; set; }
    bool DOEOnly { get; set; }
}