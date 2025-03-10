#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Runtime.Serialization;

namespace AgencyPro.Domain.Entities;

public class UserToken : IdentityUserToken<int>, IEntityTypeConfiguration<UserToken>, IObjectState
{
    public User User { get; set; }

    public void Configure(EntityTypeBuilder<UserToken> builder)
    {
        builder.HasKey(x => new
        {
            x.UserId,
            x.LoginProvider,
            x.Name
        });

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserTokens)
            .HasForeignKey(x => x.UserId);
    }

    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}