using Bespoke.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using ResumePro.Api.Services;
using ResumePro.Data.Contexts;
using Serilog;

namespace ResumePro.Api;

public class Program
{
    public static void Main(string[] args)
    {
        // Check if we're running in migration mode
        if (args.Length > 0 && args[0].Contains("migrate"))
        {
            // Run migrations directly
            RunMigrations();
            return;
        }

        BuildHost(args)
            .Init();
    }

    private static void RunMigrations()
    {
        // Configure logging
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .CreateLogger();

        Log.Information("Running migrations...");

        // Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        // Create a service collection
        var services = new ServiceCollection();
        
        // Add DbContext
        services.AddDbContext<ApplicationContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("PostgreSQLConnection");
            options.UseNpgsql(connectionString, npgsqlOptions =>
            {
                npgsqlOptions.MigrationsAssembly("ResumePro.Infrastructure.PostgreSQL");
            });
        });

        // Build service provider
        var serviceProvider = services.BuildServiceProvider();

        // Get DbContext and run migrations
        using var scope = serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
        
        Log.Information("Applying migrations to PostgreSQL database...");
        dbContext.Database.Migrate();
        
        Log.Information("Migrations completed successfully.");
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
            })
            .ConfigureServices(services =>
            {
                services.AddSingleton<AngularAppService>();
            });
    }
}
