namespace AgencyPro.Shared.Models;

public class PromoteLeadResult : Result
{
    public Guid LeadId { get; set; }
    public int? AccountNumber { get; set; }
    public Guid? CustomerOrganizationId { get; set; }
    public bool AccountLinked { get; set; }
    public bool AccountCreated { get; set; }
}