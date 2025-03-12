using System.ComponentModel.DataAnnotations.Schema;
using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class RoleClaim : IdentityRoleClaim<int>, IObjectState, IEntityTypeConfiguration<RoleClaim>
{
    public Role Role { get; set; }

    public void Configure(EntityTypeBuilder<RoleClaim> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Role)
            .WithMany(x => x.RoleClaims)
            .HasForeignKey(x => x.RoleId);
    }

    [NotMapped] public ObjectState ObjectState { get; set; }
}