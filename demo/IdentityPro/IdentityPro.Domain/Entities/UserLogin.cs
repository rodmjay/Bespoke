﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class UserLogin : IdentityUserLogin<int>, IEntityTypeConfiguration<UserLogin>, IObjectState
{
    public User User { get; set; } = null!;

    public void Configure(EntityTypeBuilder<UserLogin> builder)
    {
        builder.HasKey(x => new
        {
            x.UserId,
            x.ProviderKey,
            x.LoginProvider
        });

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserLogins)
            .HasForeignKey(x => x.UserId);
    }

    public ObjectState ObjectState { get; set; }
}
