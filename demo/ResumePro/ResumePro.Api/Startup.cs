#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.Azure.AppInsights.Extensions;
using Bespoke.Azure.BlobStorage;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Extensions;
using Bespoke.Core.Settings;
using Bespoke.Data.Extensions;
using Bespoke.Data.SqlServer;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Middleware;
using Bespoke.Rest.Swagger.Extensions;
using Bespoke.Shared.Enums;
using Microsoft.Extensions.Options;
using ResumePro.Data.Contexts;
using ResumePro.Services.Extensions;

namespace ResumePro.Api;

public sealed class Startup
{
    public Startup(IConfiguration configuration,
        IWebHostEnvironment environment)
    {
        Environment = environment;
        Configuration = configuration;
    }

    public IWebHostEnvironment Environment { get; }
    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCompositeRoot(Configuration, builder =>
        {
            builder
                .AddEventAggregator()
                .AddAutomapper()
                .AddStorage(
                    configureDbSettings: dbSettings =>
                    {
                        dbSettings.MigrationsAssembly = "ResumePro.Infrastructure.SqlServer";
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
                                appInsightsSettings.CloudRoleName = "RESUMEPRO";
                                appInsightsSettings.EnableAdaptiveSampling = true;
                                appInsightsSettings.EnableDependencyTrackingTelemetryModule = false;
                            });
                        azureBuilder.AddBlobStorage();
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

            builder.Services.AddServices(Configuration);
        });

        //var thisAssembly = Assembly.GetAssembly(GetType());
        //var businessAssembly = typeof(ApplicationContext).Assembly;

        //var builder = services.ConfigureApp(Configuration).AddDatabase<ApplicationContext>()
        //    .AddAutomapperProfilesFromAssemblies()
        //    .RegisterHandlebarsExtensions()
        //    .AddAppInsights()
        //    .RegisterPdfGeneration()
        //    .RegisterAllServices(businessAssembly);

        //var webAppBuilder = builder.ConfigureWebApp(Environment);

        //var restBuilder = webAppBuilder.ConfigureRest()
        //    .AddCors()
        //    .AddAuthorization()
        //    .AddBearerAuthentication(_identityServerMessageHandler)
        //    .AddSwagger(thisAssembly);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context,
        IOptions<AppSettings> settings)
    {

        app.UseMiddleware<ExceptionMiddleware>();

        //if (settings.Value.Mode == OperationMode.Demo)
        //    app.UseMiddleware<DemoModeMiddleware>();
        //else
        //    app.UseMiddleware<LiveModeMiddleware>();


        var appSettings = settings.Value;

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint($"/swagger/{settings.Value.Version}/swagger.json", appSettings.Name);
            c.RoutePrefix = "swagger";  // Changed from string.Empty to "swagger"
        });

        // Serve Angular’s static files (index.html, etc.)
        app.UseDefaultFiles();
        app.UseStaticFiles();

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}