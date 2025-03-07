using AssetScope.Shared.Enums;
using AssetScope.Shared.Interfaces;

namespace AssetScope.Shared.Models;

public class UserInfo : IUserInfo, IPermissions
{
    public List<AgencyRoleEnum> Roles { get; set; } = new();

    public bool IsSuperAdmin => Roles.Contains(AgencyRoleEnum.SuperAdmin);
    public bool HasSuperAdminRights => IsSuperAdmin;

    public bool IsAdmin => Roles.Contains(AgencyRoleEnum.Admin);
    public bool HasAdminRights => (AccessLevel & (int)AgencyRoleEnum.Admin) == (int)AgencyRoleEnum.Admin;

    public bool IsController => Roles.Contains(AgencyRoleEnum.Controller);
    public bool HasControllerRights => (AccessLevel & (int)AgencyRoleEnum.Controller) == (int)AgencyRoleEnum.Controller;

    public bool IsSectionChief => Roles.Contains(AgencyRoleEnum.SectionChief);

    public bool HasSectionChiefRights =>
        (AccessLevel & (int)AgencyRoleEnum.SectionChief) == (int)AgencyRoleEnum.SectionChief;

    public bool IsContractApprover => Roles.Contains(AgencyRoleEnum.ContractTeamApprover);

    public bool HasContractApproverRights => (AccessLevel & (int)AgencyRoleEnum.ContractTeamApprover) ==
                                             (int)AgencyRoleEnum.ContractTeamApprover;

    public bool IsFinanceTeamApprover => Roles.Contains(AgencyRoleEnum.FinanceTeamApprover);

    public bool HasFinanceTeamApproverRights => (AccessLevel & (int)AgencyRoleEnum.FinanceTeamApprover) ==
                                                (int)AgencyRoleEnum.FinanceTeamApprover;

    public bool IsEntryUser => Roles.Contains(AgencyRoleEnum.EntryUser);

    public bool HasEntryApproverRights =>
        (AccessLevel & (int)AgencyRoleEnum.EntryUser) == (int)AgencyRoleEnum.EntryUser;

    public int AccessLevel => Roles.Aggregate(0, (acc, role) => acc | (int)role);
    public int Id { get; set; }
    public string Email { get; set; } = null!;
}