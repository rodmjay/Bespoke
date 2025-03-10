#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Runtime.Serialization;

namespace AgencyPro.Domain.Entities;

public class UserClaim : IdentityUserClaim<int>, IEntityTypeConfiguration<UserClaim>, IObjectState
{
    public User User { get; set; }

    public void Configure(EntityTypeBuilder<UserClaim> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserClaims)
            .HasForeignKey(x => x.UserId);
    }

    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}