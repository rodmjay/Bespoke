using TechValley.Azure.Builders;
using TechValley.Core.Builders;
using TechValley.Core.Helpers;

namespace TechValley.Azure.Extensions
{
    public static class AzureExtensions
    {
        public static AppBuilder AddAzure(this AppBuilder appBuilder, Action<AzureBuilder>? build = default)
        {
            (appBuilder.Configuration, appBuilder.Services)
                .ConfigureSettings<AzureSettings>("AzureSettings");

            var azureBuilder = new AzureBuilder(appBuilder);
            
            build?.Invoke(azureBuilder);

            return appBuilder;
        }

    }
}
