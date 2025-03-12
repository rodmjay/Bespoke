namespace AgencyPro.Domain.Entities;

public abstract class Notification<T> : BaseEntity<T>, INotification where T : class
{
    public Guid Id { get; set; }
    public Guid OrganizationId { get; set; }
    public string Message { get; set; } = null!;
    public string Url { get; set; } = null!;
    public NotificationType Type { get; set; }
    public Guid UserId { get; set; }
    public bool RequiresAcknowledgement { get; set; }
    public bool? Acknowledged { get; set; }
}