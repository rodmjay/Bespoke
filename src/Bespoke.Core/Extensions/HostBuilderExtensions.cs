﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Debugging;
using Serilog.Events;
using Bespoke.Core.Helpers;
using ILogger = Serilog.ILogger;

namespace Bespoke.Core.Extensions;

[ExcludeFromCodeCoverage]
public static class HostBuilderExtensions
{
    public static IConfiguration Configuration { get; set; }

    public static void ConfigureLogging(WebHostBuilderContext hostingContext, ILoggingBuilder logging)
    {
        logging.AddConsole();

        if (EnvironmentHelpers.IsDevelopment(hostingContext.HostingEnvironment))
        {
            logging.AddDebug();
            logging.SetMinimumLevel(LogLevel.Debug);
        }
        else
        {
            logging.SetMinimumLevel(LogLevel.Information);
        }

        //logging.AddFilter(DbLoggerCategory.Database.Connection.Name, LogLevel.Information);
        logging.AddFilter("ResumePro", LogLevel.Information);
        logging.AddFilter("ResumePro.Shared", LogLevel.Information);
        logging.AddFilter("IdentityServer4", LogLevel.Warning);
    }


    public static void Configure(HostBuilderContext hostingContext,
        IConfigurationBuilder config)
    {
        var env = hostingContext.HostingEnvironment;
        Configure(config, env.EnvironmentName);
    }

    public static void Configure(IConfigurationBuilder config, string environmentName)
    {
        config
            .AddJsonFile("appsettings.json", true)
            .AddJsonFile($"appsettings.{environmentName}.json", true);

        config
            .AddEnvironmentVariables()
            .Build();
    }


    public static ILogger CreateLogger(IServiceProvider serviceProvider)
    {
        SelfLog.Enable(msg =>
        {
            Debug.Print(msg);
            Debugger.Break();
        });

        var telemetryConfig = serviceProvider.GetService<TelemetryConfiguration>();

        var loggerConfig = new LoggerConfiguration()
            .MinimumLevel
            .Debug()
            .Enrich
            .FromLogContext()
            .WriteTo
            .Console(LogEventLevel.Debug,
                "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}");
           
            //.WriteTo
            //.File(@"c:\home\logfiles\application\myapp.txt",
            //    outputTemplate:
            //    "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
            //    fileSizeLimitBytes: 1_000_000,
            //    rollOnFileSizeLimit: true,
            //    shared: true,
            //    flushToDiskInterval: TimeSpan.FromSeconds(1));

        if (telemetryConfig != null)
        {
            loggerConfig.WriteTo.ApplicationInsights(telemetryConfig,
                    TelemetryConverter.Traces);
        }

        return loggerConfig.CreateLogger();
    }


    public static void Init(
        this IHostBuilder hostBuilder,
        string initMessage = "Starting Application",
        string exceptionMessage = "Application terminated unexpectedly"
    )
    {
        var host = hostBuilder.Build();

        Log.Logger = CreateLogger(host.Services.GetRequiredService<IServiceProvider>());

        try
        {
            Log.Information(initMessage);
            host.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, exceptionMessage);
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}