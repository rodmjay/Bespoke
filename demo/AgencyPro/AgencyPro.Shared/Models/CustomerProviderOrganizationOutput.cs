namespace AgencyPro.Shared.Models
{
    /// <summary>
    /// Customer's view of a provider organization
    /// </summary>
    public class CustomerProviderOrganizationOutput : OrganizationDto
    {
        [JsonIgnore]
        public override OrganizationType OrganizationType { get; set; }

        [JsonIgnore]
        public override DateTimeOffset Updated { get; set; }

        public IDictionary<Guid, int> Skills { get; set; }
    }
}