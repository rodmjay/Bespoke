#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bespoke.Data.Bases;

namespace Bespoke.Tests.Stubs;

public class TestEntity : BaseEntity<TestEntity>, IValidatableObject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override void Configure(EntityTypeBuilder<TestEntity> builder)
    {
        builder.HasKey(x => x.Id);
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Name == "invalid")
        {
            yield return new ValidationResult("Validation failed", new List<string>() {nameof(Name)});
        }
    }
}