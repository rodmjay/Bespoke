using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum SearchTokens
{
    [Description("$UserName$")]
    UserName = 1,

    [Description("$WorkflowName$")]
    WorkflowName = 2,

    [Description("$ActionName$")]
    ActionName = 3,

    [Description("$StepName$")]
    StepName = 4,

    [Description("$ContractId$")]
    ContractId = 5,
}