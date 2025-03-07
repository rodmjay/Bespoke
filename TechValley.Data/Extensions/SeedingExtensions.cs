#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechValley.Data.Helpers;
using TechValley.Data.Services;

namespace TechValley.Data.Extensions;

public static class SeedingExtensions
{
    
    // Extension method for EntityTypeBuilder to support the fluent syntax
    public static void Seed<TEntity>(this EntityTypeBuilder<TEntity> builder, string fileName)
        where TEntity : class
    {
        var assembly = AssemblyFinder.FindSeedAssembly();
        if (assembly != null)
        {

            var seedingExtensions = new SeedingService(assembly);
            seedingExtensions.Seed(builder, fileName);
        }

    }
}