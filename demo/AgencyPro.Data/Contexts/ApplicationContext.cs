#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
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
        
        // Configure a default column type for all decimal properties
        foreach (var property in builder.Model.GetEntityTypes()
                                        .SelectMany(t => t.GetProperties())
                                        .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18,2)");
        }
        
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            // Loop over all foreign keys for each entity type
            foreach (var foreignKey in entityType.GetForeignKeys())
            {
                // Set the delete behavior to NoAction
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }


}
