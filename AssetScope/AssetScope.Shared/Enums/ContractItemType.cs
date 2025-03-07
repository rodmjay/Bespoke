using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum ContractItemType
{
    [Description("Contract")] Contract = 1,

    [Description("Contract Amendment")] ContractAmendment = 2,

    [Description("Grant")] Grant = 3,

    [Description("Grant Amendment")] GrantAmendment = 4,

    [Description("MOU")] MOU = 5,

    [Description("MOU Amendment")] MOUAmendment = 6
}