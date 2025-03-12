namespace AgencyPro.Shared.Models;

public class OrganizationBonusIntentOutput : IOrganizationBonusIntent
{
    public Guid Id { get; set; }
    public Guid OrganizationId { get; set; }
    public BonusType BonusType { get; set; }
    public string TransferId { get; set; } = null!;
    public decimal Amount { get; set; }
    public string Description { get; set; } = null!;
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }
}