using Bespoke.Data.Builders;
using Bespoke.Data.SqlServer;
using Microsoft.Extensions.Configuration;
using ResumePro.Data.Contexts;
using ResumePro.Infrastructure.PostgreSQL;

namespace ResumePro.Api.Extensions;

public static class DatabaseProviderExtensions
{
    public static void ConfigureDatabaseProvider(this DataBuilder dataBuilder, IConfiguration configuration)
    {
        // Always use PostgreSQL
        dataBuilder.Settings.MigrationsAssembly = "ResumePro.Infrastructure.PostgreSQL";
        dataBuilder.UsePostgreSQLApplicationContext();
    }
}
