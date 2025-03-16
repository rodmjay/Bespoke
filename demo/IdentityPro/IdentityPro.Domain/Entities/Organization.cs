using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class Organization : BaseEntity<Organization>
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<UserOrganization> UserOrganizations { get; set; } = new List<UserOrganization>();

    public override void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
