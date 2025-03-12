#nullable enable

using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Azure.Extensions;

public static class AzureExtensions
{
    public static AppBuilder AddAzure(this AppBuilder appBuilder,
        Action<AzureSettings>? configureAzureSettings = null,
        Action<AzureBuilder>? configureAzureBuilder = null)
    {
        // Load AzureSettings from configuration
        var azureSettings = new AzureSettings();
        appBuilder.Configuration.GetSection("AzureSettings")
            .Bind(azureSettings);

        // Allow users to modify AzureSettings before injecting into DI
        configureAzureSettings?.Invoke(azureSettings);

        // Register modified AzureSettings
        appBuilder.Services.Configure<AzureSettings>(options =>
        {
            options.UseAzureManagedIdentity = azureSettings.UseAzureManagedIdentity;
            options.AccountKey = azureSettings.AccountKey;
            options.AccountName = azureSettings.AccountName;
        });

        // Allow users to configure the AzureBuilder
        var azureBuilder = new AzureBuilder(appBuilder, azureSettings);
        configureAzureBuilder?.Invoke(azureBuilder);

        return appBuilder;
    }
}