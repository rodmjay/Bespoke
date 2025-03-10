#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

namespace AgencyPro.Domain.Entities;

public class Role : IdentityRole<int>, IObjectState, IRole, IEntityTypeConfiguration<Role>
{
    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<RoleClaim> RoleClaims { get; set; }

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

    [NotMapped] public ObjectState ObjectState { get; set; }
}