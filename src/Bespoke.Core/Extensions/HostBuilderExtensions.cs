using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Bespoke.Core.Serilog.Enrichers;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace Bespoke.Core.Extensions;

[ExcludeFromCodeCoverage]
public static class HostBuilderExtensions
{
    public static void ConfigureAppConfiguration(HostBuilderContext hostingContext,
        IConfigurationBuilder config)
    {
        var env = hostingContext.HostingEnvironment;
        config
            .AddJsonFile("appsettings.json", true);

        config
            .AddEnvironmentVariables()
            .Build();
    }

    public static IHost Init(
        this IHostBuilder hostBuilder,
        string initMessage = "Starting Application",
        string exceptionMessage = "Application terminated unexpectedly"
    )
    {
        var host = hostBuilder.Build();

        try
        {
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

        return host;
    }

    public static void ConfigureLogging(HostBuilderContext context, IServiceProvider serviceProvider,
        LoggerConfiguration loggerConfig)
    {
        var scope = serviceProvider.CreateScope();

        var telemetryConfig = scope.ServiceProvider.GetService<TelemetryConfiguration>();

        // Log a warning if telemetry configuration is not available.
        if (telemetryConfig == null)
            Debug.Print(
                "Warning: TelemetryConfiguration is not available; ApplicationInsights sink will not be configured.");

        // Create the logger configuration with additional enrichers.
        loggerConfig
            .ReadFrom.Configuration(context.Configuration)
            .Enrich.FromLogContext()
            .Enrich.With(new ClaimsPrincipalEnricher(scope.ServiceProvider.GetService<IHttpContextAccessor>()))
            .WriteTo.Async(a => a.Console(
                LogEventLevel.Debug,
                "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} | UserId: {User}{NewLine}{Exception}"
            ));

        // Conditionally add Application Insights sink if telemetry is available.
        if (telemetryConfig != null)
            _ = loggerConfig.WriteTo.ApplicationInsights(telemetryConfig, TelemetryConverter.Traces);

        // Configure file logging only if "log_path" environment variable is defined.
        var logPath = Environment.GetEnvironmentVariable("LOG_PATH");
        if (!string.IsNullOrWhiteSpace(logPath))
        {
            Directory.CreateDirectory(logPath);
            var logFilePath = Path.Combine(logPath, "logs.txt");

            loggerConfig.WriteTo.File(
                logFilePath,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                fileSizeLimitBytes: 1_000_000,
                rollOnFileSizeLimit: true,
                shared: true,
                flushToDiskInterval: TimeSpan.FromSeconds(1));
        }
    }
}