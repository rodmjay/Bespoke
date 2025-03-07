#region Header Info

// Copyright 2024 BespokeTalent.  All rights reserved

#endregion

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Bespoke.Core.Extensions;

namespace Bespoke.IntegrationTesting.Extensions;

public static class CustomWebHostBuilderExtensions
{
    public static void Configure<TFixture>(WebHostBuilderContext hostingContext,
        IConfigurationBuilder config)
    {
        var env = hostingContext.HostingEnvironment;
        var integrationTestAssembly = typeof(TFixture).Assembly;

        config
            .AddEmbeddedJsonFile(integrationTestAssembly, "appsettings.json", true);

        config
            .AddEnvironmentVariables()
            .Build();
    }
}