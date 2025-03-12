using Bespoke.Shared.Interfaces;

namespace AgencyPro.Shared.Interfaces;

public interface IOrganizationMembership : ISoftDelete
{
    Guid OrganizationId { get; set; }
    Guid PersonId { get; set; }
    PersonStatus Status { get; set; }
    bool IsHidden { get; set; }
    long PersonFlags { get; set; }
    long AgencyFlags { get; set; }
    bool IsOrganizationOwner { get; set; }
    bool IsDefault { get; set; }
    DateTimeOffset Created { get; set; }
    DateTimeOffset Updated { get; set; }
}