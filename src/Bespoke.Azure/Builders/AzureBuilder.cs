using Bespoke.Core.Builders;

namespace Bespoke.Azure.Builders;

public class AzureBuilder : BuilderBase
{
    public AzureBuilder(AppBuilder appBuilder, AzureSettings settings) : base(appBuilder)
    {
        Settings = settings;
    }

    public AzureSettings Settings { get; }
}