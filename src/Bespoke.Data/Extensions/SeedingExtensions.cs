#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bespoke.Data.Helpers;
using Bespoke.Data.Services;

namespace Bespoke.Data.Extensions;

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