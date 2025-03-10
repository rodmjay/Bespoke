﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

namespace AgencyPro.Domain.Entities;

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