namespace AgencyPro.Domain.Events;

public class OrganizationCreatedEvent
{
    public Guid OrganizationId { get; set; }
    public Guid UserId { get; set; }
}