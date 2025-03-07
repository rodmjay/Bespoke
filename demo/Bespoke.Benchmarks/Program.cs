using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bespoke.Core.Extensions;

namespace Bespoke.Benchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            IConfigurationBuilder builder = new ConfigurationBuilder();

            var appBuilder = services
                .CreateAppBuilder(builder.Build());

            var serviceProvider = appBuilder.Build();
            
            Console.WriteLine("Hello, World!");
        }
    }
}
