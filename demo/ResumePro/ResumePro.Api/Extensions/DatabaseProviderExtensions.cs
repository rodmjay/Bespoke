using Bespoke.Data.Builders;
using Bespoke.Data.SqlServer;
using Bespoke.Data.SQLite;
using Microsoft.Extensions.Configuration;
using ResumePro.Data.Contexts;

namespace ResumePro.Api.Extensions;

public static class DatabaseProviderExtensions
{
    public static void ConfigureDatabaseProvider(this DataBuilder dataBuilder, IConfiguration configuration)
    {
        bool useSQLite = configuration.GetValue<bool>("AppSettings:UseSQLite");
        
        if (useSQLite)
        {
            dataBuilder.UseSQLite<ApplicationContext>(sqliteSettings =>
            {
                sqliteSettings.ConnectionStringName = "SQLiteConnection";
            });
        }
        else
        {
            dataBuilder.UseSqlServer<ApplicationContext>(sqlSettings =>
            {
                sqlSettings.ConnectionStringName = "DefaultConnection";
            });
        }
    }
}
