using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models;

public class RecruiterContractDetailsOutput : RecruiterContractOutput
{
    public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
}