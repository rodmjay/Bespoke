using TechValley.Azure.AD.Builders;
using TechValley.Azure.Builders;
using TechValley.Core.Helpers;

namespace TechValley.Azure.AD.Extensions;

public static class AzureBuilderExtensions
{
    public static AzureBuilder AddAzureAd(this AzureBuilder builder, Action<AzureAdBuilder>? build = default)
    {
        (builder.Configuration, builder.Services).ConfigureSettings<AzureAdSettings>("AzureSettings:AzureAd");

        var adBuilder = new AzureAdBuilder(builder);

        build?.Invoke(adBuilder);

        return builder;
    }
}