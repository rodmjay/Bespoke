﻿#nullable enable

using Azure.Data.Tables;
using Bespoke.Azure.Builders;
using Bespoke.Azure.TableStorage.Builders;
using Bespoke.Azure.TableStorage.Factories;
using Bespoke.Azure.TableStorage.Interfaces;
using Bespoke.Core.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Bespoke.Azure.TableStorage.Extensions;

public static class TableStorageExtensions
{
    public static AzureBuilder AddTableStorage(this AzureBuilder builder, Action<TableStorageBuilder>? build = default)
    {
        builder.GetAppBuilder().ConfigureSettings<TableStorageSettings>("AzureSettings:TableStorage");

        var blobStorageBuilder = new TableStorageBuilder(builder);

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