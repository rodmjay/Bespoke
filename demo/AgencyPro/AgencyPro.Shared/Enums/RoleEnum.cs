namespace AgencyPro.Shared.Enums;

[Flags]
public enum RoleEnum
{
    None = 0,
    Marketer = 1 << 0, // 1
    Recruiter = 1 << 1, // 2
    Affiliate = Marketer | Recruiter, // 3
    Employee = 1 << 2, // 4
    Contractor = 1 << 3, // 8
    Worker = Employee | Contractor, // 12
    ProjectManager = 1 << 4, // 16
    AccountManager = 1 << 5, // 32
    Manager = ProjectManager | AccountManager, // 48
    AgencyOwner = Manager | Worker | Affiliate // 63
}