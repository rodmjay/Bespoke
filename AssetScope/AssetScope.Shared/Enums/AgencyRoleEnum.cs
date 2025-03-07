namespace AssetScope.Shared.Enums;

// The [Flags] attribute indicates that this enum can be treated as a bit field (a set of flags).
[Flags]
public enum AgencyRoleEnum
{
    None = 0,
    // 'None' represents no roles assigned. Its binary representation is 000000.

    EntryUser = 1 << 0, // 1
    // 'EntryUser' is the base role with a value of 1 (binary: 000001).
    // It represents the most basic access level.

    FinanceTeamApprover = EntryUser | (1 << 1), // 3 (1 | 2)
    // 'FinanceTeamApprover' is a combination of 'EntryUser' and an additional bit for this role.
    // Binary: 000001 (EntryUser) | 000010 (1 << 1) = 000011.
    // Value: 3.

    ContractTeamApprover = FinanceTeamApprover | (1 << 2), // 7 (3 | 4)
    // 'ContractTeamApprover' includes 'FinanceTeamApprover' and an additional bit for this role.
    // Binary: 000011 (FinanceTeamApprover) | 000100 (1 << 2) = 000111.
    // Value: 7.

    SectionChief = EntryUser | (1 << 3), // 9 (1 | 8)
    // 'SectionChief' includes 'EntryUser' and an additional bit for this role.
    // Binary: 000001 (EntryUser) | 001000 (1 << 3) = 001001.
    // Value: 9.

    Controller = EntryUser | (1 << 4), // 17 (1 | 16)
    // 'Controller' includes 'EntryUser' and an additional bit for this role.
    // Binary: 000001 (EntryUser) | 010000 (1 << 4) = 010001.
    // Value: 17.

    Admin = EntryUser | SectionChief | ContractTeamApprover | Controller, // 31
    // 'Admin' combines multiple roles: 'EntryUser', 'SectionChief', 'ContractTeamApprover', and 'Controller'.
    // Binary: 
    // 000001 (EntryUser) 
    // | 001001 (SectionChief) 
    // | 000111 (ContractTeamApprover) 
    // | 010001 (Controller) 
    // = 011111.
    // Value: 31.

    SuperAdmin = Admin | (1 << 5) // 63
    // 'SuperAdmin' includes all 'Admin' permissions and adds another bit for additional capabilities.
    // Binary: 011111 (Admin) | 100000 (1 << 5) = 111111.
    // Value: 63.
}