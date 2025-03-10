using Bespoke.Azure.AppInsights.Services;
using Bespoke.Core.Builders;
using Bespoke.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Bespoke.Azure.AppInsights;

public class AppInsightsBuilder : BuilderBase
{
    public AppInsightsBuilder(IBuilder builder) : base(builder)
    {
        builder.Services.TryAddScoped<ICustomEventLogger, CustomEventLogger>();
    }
}