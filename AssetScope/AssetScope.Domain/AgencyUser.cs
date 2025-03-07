using System.ComponentModel.DataAnnotations.Schema;
using AssetScope.Shared.Enums;
using Bespoke.Data.Bases;
using Bespoke.Data.Interfaces;

namespace AssetScope.Domain;

public class AgencyUser : BaseEntity, IObjectState
{
    public ICollection<AgencyRole> Roles { get; set; } = new List<AgencyRole>();
   

    public bool IsCFO { get; set; }

    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string StateOrganizationId { get; set; } = string.Empty;
    public string StaffType { get; set; } = string.Empty;
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Manual { get; set; }
    public bool DOEOnly { get; set; }

    [NotMapped]
    // calculated from the roles
    public int AccessLevel => Roles.Select(x => x.Role).Aggregate(0, (acc, role) => acc | (int)role);

    [NotMapped] public bool IsSuperAdmin => Roles.Select(x => x.Role).Contains(AgencyRoleEnum.SuperAdmin);

    [NotMapped]
    public bool HasSuperAdminRights => (AccessLevel & (int)AgencyRoleEnum.SuperAdmin) == (int)AgencyRoleEnum.SuperAdmin;

    [NotMapped] public bool IsAdmin => Roles.Select(x => x.Role).Contains(AgencyRoleEnum.Admin);

    [NotMapped] public bool HasAdminRights => (AccessLevel & (int)AgencyRoleEnum.Admin) == (int)AgencyRoleEnum.Admin;

    [NotMapped] public bool IsController => Roles.Select(x => x.Role).Contains(AgencyRoleEnum.Controller);

    [NotMapped]
    public bool HasControllerRights => (AccessLevel & (int)AgencyRoleEnum.Controller) == (int)AgencyRoleEnum.Controller;

    [NotMapped] public bool IsSectionChief => Roles.Select(x => x.Role).Contains(AgencyRoleEnum.SectionChief);

    [NotMapped]
    public bool HasSectionChiefRights =>
        (AccessLevel & (int)AgencyRoleEnum.SectionChief) == (int)AgencyRoleEnum.SectionChief;

    [NotMapped]
    public bool IsContractApprover => Roles.Select(x => x.Role).Contains(AgencyRoleEnum.ContractTeamApprover);

    [NotMapped]
    public bool HasContractApproverRights => (AccessLevel & (int)AgencyRoleEnum.ContractTeamApprover) ==
                                             (int)AgencyRoleEnum.ContractTeamApprover;

    [NotMapped]
    public bool IsFinanceTeamApprover => Roles.Select(x => x.Role).Contains(AgencyRoleEnum.FinanceTeamApprover);

    [NotMapped]
    public bool HasFinanceTeamApproverRights => (AccessLevel & (int)AgencyRoleEnum.FinanceTeamApprover) ==
                                                (int)AgencyRoleEnum.FinanceTeamApprover;

    [NotMapped] public bool IsEntryUser => Roles.Select(x => x.Role).Contains(AgencyRoleEnum.EntryUser);

    [NotMapped]
    public bool HasEntryApproverRights =>
        (AccessLevel & (int)AgencyRoleEnum.EntryUser) == (int)AgencyRoleEnum.EntryUser;
}