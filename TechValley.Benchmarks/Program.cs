using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechValley.Core.Extensions;

namespace TechValley.Benchmarks
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
