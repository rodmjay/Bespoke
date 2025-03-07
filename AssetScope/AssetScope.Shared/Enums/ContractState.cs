using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum ContractState
{
    [Description("Draft")] Draft = 0,

    [Description("In-Process")] InProcess = 1,

    [Description("Completed")] Completed = 2,

    [Description("Active")] Active = 3,

    [Description("Closed")] Closed = 4,

    [Description("Deleted")] Deleted = 5
}