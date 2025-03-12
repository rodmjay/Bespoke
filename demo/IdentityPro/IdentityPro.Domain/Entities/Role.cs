using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;
using IdentityPro.Shared.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class Role : IdentityRole<int>, IObjectState, IRole, IEntityTypeConfiguration<Role>
{
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    public ICollection<RoleClaim> RoleClaims { get; set; } = new List<RoleClaim>();

    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.UserRoles)
            .WithOne(x => x.Role)
            .HasForeignKey(x => x.RoleId);

        builder.HasMany(x => x.RoleClaims)
            .WithOne(x => x.Role)
            .HasForeignKey(x => x.RoleId);
    }

    public ObjectState ObjectState { get; set; }
}