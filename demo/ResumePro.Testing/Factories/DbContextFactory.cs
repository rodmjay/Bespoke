﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ResumePro.Context;

namespace ResumePro.Testing.Factories;

[ExcludeFromCodeCoverage]
public static class DbContextFactory
{
    public static DbContextOptions<ApplicationContext> CreateContextOptions(IConfiguration configuration)
    {
        var connString = configuration.GetConnectionString("DefaultConnection");
        var opts = new DbContextOptionsBuilder<ApplicationContext>();
        opts.UseSqlServer(connString,
            provider => provider.EnableRetryOnFailure());
        opts.EnableSensitiveDataLogging();

        return opts.Options;
    }
}