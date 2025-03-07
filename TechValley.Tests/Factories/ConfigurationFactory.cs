using Microsoft.Extensions.Configuration;

namespace TechValley.Tests.Factories;

public static class ConfigurationFactory
{
    private static readonly Dictionary<string, string> DefaultSettings = new()
    {
        { "AppSettings:Name", "Test"},
        { "DbSettings:UseContextPooling", "false" },
        { "DbSettings:SplitQueries", "false" },
        { "DbSettings:MaxBatchSize", "100" },
        { "DbSettings:MaxRetryCount", "5" },
        { "DbSettings:MaxRetryDelaySeconds", "30" },
        { "DbSettings:Timeout", "20" },
        { "AzureSettings:UseManagedIdentity", "false"},
        { "AzureSettings:AccountName", "secret"},
        { "AzureSettings:AccountKey", "secret"},
        { "AzureSettings:BlobStorage:ConnectionStringName", "BlobStorage"},
        { "AzureSettings:QueueStorage:ConnectionStringName", "QueueStorage"},
        { "ConnectionStrings:SqlServer", "Server=(localdb)\\mssqllocaldb;Database=TestDb;Trusted_Connection=True;" },
        { "ConnectionStrings:BlobStorage", "" },
        { "ConnectionStrings:QueueStorage", "" }
};

    public static IConfigurationBuilder CreateConfigurationBuilder(Action<Dictionary<string, string>> updateSettings = null)
    {
        var settings = new Dictionary<string, string>(DefaultSettings);

        // Allow updates through the provided delegate
        updateSettings?.Invoke(settings);

        return new ConfigurationBuilder().AddInMemoryCollection(settings);
    }

    public static Dictionary<string, string> GetDefaultSettings()
    {
        return new Dictionary<string, string>(DefaultSettings);
    }
}