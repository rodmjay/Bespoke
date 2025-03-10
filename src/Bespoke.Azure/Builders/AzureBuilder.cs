using Bespoke.Core.Builders;

namespace Bespoke.Azure.Builders
{
    public class AzureBuilder : BuilderBase
    {
        public AzureSettings Settings { get; }

        public AzureBuilder(AppBuilder appBuilder, AzureSettings settings) : base(appBuilder)
        {
            Settings = settings;
        }
    }
}
