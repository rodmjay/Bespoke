#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.Azure.AppInsights.Extensions;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Extensions;
using Bespoke.Core.Settings;
using Bespoke.Data;
using Bespoke.Data.Extensions;
using Bespoke.Data.SqlServer;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Swagger.Extensions;
using IdentityPro.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IdentityPro.Api;

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
                    configureDbSettings: dataSettings =>
                    {
                        dataSettings.DefaultDeleteBehavior = DeleteBehavior.NoAction;
                        dataSettings.DefaultSchema = "IdentityPro";
                        dataSettings.NamingConventionType = DbSettings.NamingConvention.SnakeCase;
                    },
                    configureDataBuilder: dataBuilder =>
                    {
                        dataBuilder.UseSqlServer<ApplicationContext>();
                    }
                )
                .AddAzure(
                    configureAzureBuilder: azureBuilder =>
                    {
                        azureBuilder.AddAppInsights();
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

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context,
        IOptions<AppSettings> settings)
    {
        RestApiBuilderExtensions.Configure(app, env, settings);
    }
}