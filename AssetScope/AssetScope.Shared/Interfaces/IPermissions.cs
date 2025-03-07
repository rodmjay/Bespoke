namespace AssetScope.Shared.Interfaces;

public interface IPermissions
{
    public int Id { get; set; }
    bool IsSuperAdmin { get; }
    bool HasSuperAdminRights { get; }
    bool IsAdmin { get; }
    bool HasAdminRights { get; }
    bool IsController { get; }
    bool HasControllerRights { get; }
    bool IsSectionChief { get; }
    bool HasSectionChiefRights { get; }
    bool IsContractApprover { get; }
    bool HasContractApproverRights { get; }
    bool IsFinanceTeamApprover { get; }
    bool HasFinanceTeamApproverRights { get; }
    bool IsEntryUser { get; }
    bool HasEntryApproverRights { get; }
    int AccessLevel { get; }
}