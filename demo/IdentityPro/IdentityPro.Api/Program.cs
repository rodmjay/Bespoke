#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.Core.Extensions;
using Serilog;

namespace IdentityPro.Api;

public class Program
{
    public static void Main(string[] args)
    {
        BuildHost(args)
            .Init();
    }

    public static IHostBuilder BuildHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(HostBuilderExtensions.ConfigureAppConfiguration)
            .UseSerilog(HostBuilderExtensions.ConfigureLogging)
            .ConfigureWebHostDefaults(builder =>
            {
                builder
                    .UseStartup<Startup>();
            });
    }
}