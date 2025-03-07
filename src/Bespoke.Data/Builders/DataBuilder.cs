using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bespoke.Core.Builders;

namespace Bespoke.Data.Builders
{
    public class DataBuilder : IBuilder
    {
        private readonly AppBuilder _appBuilder;

        public DataBuilder(AppBuilder appBuilder)
        {
            _appBuilder = appBuilder;
        }

        public IServiceCollection Services => _appBuilder.Services;

        public IConfiguration Configuration => _appBuilder.Configuration;
    }
}
