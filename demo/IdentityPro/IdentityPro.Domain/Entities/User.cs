using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;
using IdentityPro.Shared.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class User : IdentityUser<int>, IEntityTypeConfiguration<User>, IObjectState, IUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FullName => FirstName + " " + LastName;

    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    public ICollection<UserToken> UserTokens { get; set; } = new List<UserToken>();
    public ICollection<UserLogin> UserLogins { get; set; } = new List<UserLogin>();
    public ICollection<UserClaim> UserClaims { get; set; } = new List<UserClaim>();

    public ICollection<UserOrganization> UserOrganizations { get; set; } = new List<UserOrganization>();

    public Guid? CurrentApplication { get; set; }

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Ignore(x => x.FullName);

        builder.Property(f => f.Id)
            .ValueGeneratedOnAdd();

        builder.HasMany(x => x.UserRoles)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.UserTokens)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.UserLogins)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.UserClaims)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relationship with Organization is now configured through UserOrganization entity
    }

    public ObjectState ObjectState { get; set; }
}
