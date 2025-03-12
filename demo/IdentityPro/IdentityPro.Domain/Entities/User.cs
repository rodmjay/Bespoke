﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;
using IdentityPro.Shared.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class User : IdentityUser<int>, IEntityTypeConfiguration<User>, IObjectState, IUser
{
    public User()
    {
        UserRoles = new List<UserRole>();
        UserTokens = new List<UserToken>();
        UserLogins = new List<UserLogin>();
        UserClaims = new List<UserClaim>();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => FirstName + " " + LastName;

    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<UserToken> UserTokens { get; set; }
    public ICollection<UserLogin> UserLogins { get; set; }
    public ICollection<UserClaim> UserClaims { get; set; }

    public Organization Organization { get; set; }
    public int OrganizationId { get; set; }

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

        builder.HasOne(x => x.Organization)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.OrganizationId)
            .OnDelete(DeleteBehavior.Cascade);
    }

    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}