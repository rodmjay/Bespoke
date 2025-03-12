#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class Organization : BaseEntity<Organization>
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<User> Users { get; set; } = new List<User>();

    public override void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.HasKey(x => x.Id);
    }
}