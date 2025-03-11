namespace AgencyPro.Shared.Models
{
    public class TimeEntryResult : Result
    {
        public Guid? TimeEntryId { get; set; }
        public Guid[] TimeEntryIds { get; set; }
    }
}