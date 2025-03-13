using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class UserToken : IdentityUserToken<int>, IEntityTypeConfiguration<UserToken>, IObjectState
{
    public User User { get; set; } = null!;

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

    public ObjectState ObjectState { get; set; }
}