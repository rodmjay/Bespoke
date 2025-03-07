using AssetScope.Data.Contexts;
using Bespoke.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace AssetScope.Api.Factories;

public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            .AddJsonFile("appsettings.json", false, true);

        var config = builder.Build();

        var dbSettings = config.GetSection("DbSettings").Get<DbSettings>() ?? new DbSettings();

        var settings = new OptionsWrapper<DbSettings>(dbSettings);

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>()
            .EnableSensitiveDataLogging()
            .UseSqlServer(config.GetConnectionString("DefaultConnection"),
                opt => { opt.MigrationsAssembly("AssetScope.Infrastructure"); });

        return new ApplicationContext(optionsBuilder.Options, settings);
    }
}