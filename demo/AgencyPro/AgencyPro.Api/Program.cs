#region Header Info
// Copyright 2024 Rod Johnson.  All rights reserved
#endregion

using AgencyPro.Data.Contexts;
using Bespoke.Azure.AppInsights.Extensions;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Extensions;
using Bespoke.Data.Extensions;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Swagger.Extensions;
using Serilog;
using Bespoke.Data.SqlServer;

namespace AgencyPro.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(HostBuilderExtensions.ConfigureAppConfiguration)
                .UseSerilog(HostBuilderExtensions.ConfigureLogging)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices(services =>
                    {
                        var config = services.BuildServiceProvider()
                            .GetRequiredService<IConfiguration>();

                        services.AddCompositeRoot(config, builder =>
                        {
                            builder
                                .AddEventAggregator()
                                .AddAutomapper()
                                .AddStorage(
                                    configureDbSettings: dbSettings =>
                                    {
                                        dbSettings.MigrationsAssembly = "AgencyPro.Infrastructure.SqlServer";
                                        dbSettings.MaxRetryCount = 5;
                                    },
                                    configureDataBuilder: dataBuilder =>
                                    {
                                        dataBuilder.UseSqlServer<ApplicationContext>(sqlSettings =>
                                        {
                                            sqlSettings.ConnectionStringName = "DefaultConnection";
                                        });
                                    }
                                )
                                .AddAzure(
                                    configureAzureSettings: azureSettings =>
                                    {
                                        azureSettings.UseAzureManagedIdentity = true;
                                        azureSettings.AccountName = "MyAzureStorageAccount";
                                        azureSettings.AccountKey = "SuperSecretKey";
                                    },
                                    configureAzureBuilder: azureBuilder =>
                                    {
                                        azureBuilder.AddAppInsights(
                                            configureAppInsightsSettings: appInsightsSettings =>
                                            {
                                                appInsightsSettings.CloudRoleName = "AGENCYPRO";
                                                appInsightsSettings.EnableAdaptiveSampling = true;
                                                appInsightsSettings.EnableDependencyTrackingTelemetryModule = false;
                                            });
                                    })
                                .AddRest(configureRestSettings: restSettings =>
                                    {
                                        restSettings.Cors.AllowAnyOrigin = true;
                                    },
                                    configureRestApi: restBuilder =>
                                    {
                                        restBuilder.AddSwagger(options =>
                                        {
                                            options.SwaggerGenDemoMode();
                                        });
                                    });

                            //builder.Services.AddServices(config);
                        });

                    });
                });
    }
}