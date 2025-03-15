using System.ComponentModel.DataAnnotations.Schema;
using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class UserRole : IdentityUserRole<int>, IObjectState, IEntityTypeConfiguration<UserRole>
{
    public User User { get; set; } = null!;
    public Role Role { get; set; } = null!;

    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(x => new
        {
            x.UserId,
            x.RoleId
        });

        builder.HasOne(x => x.Role)
            .WithMany(x => x.UserRoles)
            .HasForeignKey(x => x.RoleId);

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserRoles)
            .HasForeignKey(x => x.UserId);
    }

    [NotMapped] public ObjectState ObjectState { get; set; }
}
