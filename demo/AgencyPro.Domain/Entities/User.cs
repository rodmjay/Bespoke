#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Runtime.Serialization;

namespace AgencyPro.Domain.Entities;

public class User : IdentityUser<Guid>, IEntityTypeConfiguration<User>, IObjectState,
    IUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FullName => FirstName + " " + LastName;
    public bool SendMail { get; set; }

    public Person Person { get; set; }
    public virtual ICollection<UserNotification> Notifications { get; set; }
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Ignore(x => x.FullName);

        builder.Property(f => f.Id)
            .ValueGeneratedOnAdd();

        //builder.HasMany(x => x.UserRoles)
        //    .WithOne(x => x.User)
        //    .HasForeignKey(x => x.UserId)
        //    .OnDelete(DeleteBehavior.Cascade);

        //builder.HasMany(x => x.UserTokens)
        //    .WithOne(x => x.User)
        //    .HasForeignKey(x => x.UserId)
        //    .OnDelete(DeleteBehavior.Cascade);

        //builder.HasMany(x => x.UserLogins)
        //    .WithOne(x => x.User)
        //    .HasForeignKey(x => x.UserId)
        //    .OnDelete(DeleteBehavior.Cascade);

        //builder.HasMany(x => x.UserClaims)
        //    .WithOne(x => x.User)
        //    .HasForeignKey(x => x.UserId)
        //    .OnDelete(DeleteBehavior.Cascade);
        
    }

    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}
