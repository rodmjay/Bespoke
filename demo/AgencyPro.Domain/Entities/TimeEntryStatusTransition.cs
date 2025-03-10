namespace AgencyPro.Domain.Entities
{
    public class TimeEntryStatusTransition : IObjectState
    {
        public int Id { get; set; }
        
        public Guid TimeEntryId { get; set; }

        public TimeStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public ObjectState ObjectState { get; set; }
    }
}