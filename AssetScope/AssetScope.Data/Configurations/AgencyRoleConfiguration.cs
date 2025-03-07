using AssetScope.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetScope.Data.Configurations;

public class AgencyRoleConfiguration : IEntityTypeConfiguration<AgencyRole>
{
    public void Configure(EntityTypeBuilder<AgencyRole> builder)
    {
        builder.HasKey(x => new { x.AgencyUserId, x.Role });

        builder.HasOne(x => x.AgencyUser)
            .WithMany(x => x.Roles)
            .HasForeignKey(x => x.AgencyUserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}