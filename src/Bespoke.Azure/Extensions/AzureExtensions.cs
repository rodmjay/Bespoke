using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Bespoke.Core.Helpers;

namespace Bespoke.Azure.Extensions
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
