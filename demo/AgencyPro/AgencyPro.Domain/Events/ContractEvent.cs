namespace AgencyPro.Domain.Events;

public abstract class ContractEvent
{
    public Guid ContractId { get; set; }
}