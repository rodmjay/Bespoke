using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using TechValley.Azure.Builders;
using TechValley.Azure.TableStorage.Builders;
using TechValley.Azure.TableStorage.Factories;
using TechValley.Azure.TableStorage.Interfaces;
using TechValley.Azure.TableStorage.Services;
using TechValley.Core.Helpers;

namespace TechValley.Azure.TableStorage.Extensions;

public static class TableStorageExtensions
{
    public static AzureBuilder AddTableStorage(this AzureBuilder builder, Action<TableStorageBuilder>? build = default)
    {
        builder.GetAppBuilder().ConfigureSettings<TableStorageSettings>("AzureSettings:TableStorage");

        TableStorageBuilder blobStorageBuilder = new TableStorageBuilder(builder);

        builder.Services.AddSingleton(x =>
        {
            var options = x.GetRequiredService<IOptions<TableStorageSettings>>();
            var connectionString = builder.Configuration.GetConnectionString(options.Value.ConnectionStringName);
            return new TableServiceClient(connectionString);
        });
        

        builder.Services.AddSingleton(typeof(ITableServiceFactory), typeof(TableServiceFactory));

        build?.Invoke(blobStorageBuilder);

        return builder;
    }
}