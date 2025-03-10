using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bespoke.Core.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bespoke.Data.Builders
{
    public class DataBuilder : IBuilder
    {
        public DbSettings Settings { get; }
        private readonly AppBuilder _appBuilder;

        public DataBuilder(AppBuilder appBuilder, DbSettings settings)
        {
            Settings = settings;
            _appBuilder = appBuilder;
        }

        public IServiceCollection Services => _appBuilder.Services;

        public IConfiguration Configuration => _appBuilder.Configuration;
    }
}
