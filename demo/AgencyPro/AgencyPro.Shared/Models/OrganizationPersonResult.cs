namespace AgencyPro.Shared.Models
{
    public class OrganizationPersonResult : Result
    {
        public Guid? OrganizationId { get; set; }
        public Guid? PersonId { get; set; }
    }
}