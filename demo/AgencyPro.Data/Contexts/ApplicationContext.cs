#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using AgencyPro.Domain.Entities;
using Bespoke.Data;
using Bespoke.Data.Attributes;
using Bespoke.Data.Bases;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

[assembly: SeedAssembly]

namespace AgencyPro.Data.Contexts;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public sealed class ApplicationContext : BaseContext<ApplicationContext>
{
    public ApplicationContext(
        DbContextOptions<ApplicationContext> options, IOptions<DbSettings> settings) : base(options, settings)
    {
    }

    protected override void SeedDatabase(ModelBuilder builder)
    {
       
    }

    protected override void PreModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(Organization).Assembly);
    }


}