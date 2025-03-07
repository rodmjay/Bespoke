using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Bespoke.Azure.Builders;
using Bespoke.Core.Helpers;

namespace Bespoke.Azure.BlobStorage;

public static class BlobStorageExtensions
{
    public static AzureBuilder AddBlobStorage(this AzureBuilder builder, Action<BlobStorageBuilder>? build = default)
    {
        builder.GetAppBuilder().ConfigureSettings<BlobStorageSettings>("AzureSettings:BlobStorage");

        var blobStorageBuilder = new BlobStorageBuilder(builder);

        builder.Services.AddSingleton(sp =>
        {
            var settings = sp.GetRequiredService<IOptions<BlobStorageSettings>>();
            var connectionString = builder
                .Configuration
                .GetConnectionString(settings.Value.ConnectionStringName);

            return new BlobServiceClient(connectionString);
        });
        builder.Services.AddScoped<IBlobStorageService, BlobStorageService>();

        build?.Invoke(blobStorageBuilder);

        return builder;
    }
}