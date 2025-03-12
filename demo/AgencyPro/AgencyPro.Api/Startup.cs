using AgencyPro.Data.Contexts;
using Bespoke.Azure.AppInsights.Extensions;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Extensions;
using Bespoke.Core.Settings;
using Bespoke.Data;
using Bespoke.Data.Extensions;
using Bespoke.Data.SqlServer;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Swagger.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AgencyPro.Api;

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
                    dataSettings =>
                    {
                        dataSettings.DefaultDeleteBehavior = DeleteBehavior.NoAction;
                        dataSettings.DefaultSchema = "AgencyPro";
                        dataSettings.NamingConventionType = DbSettings.NamingConvention.SnakeCase;
                    },
                    dataBuilder => { dataBuilder.UseSqlServer<ApplicationContext>(); }
                )
                .AddAzure(
                    configureAzureBuilder: azureBuilder => { azureBuilder.AddAppInsights(); })
                .AddRest(restSettings => { restSettings.Cors.AllowAnyOrigin = true; },
                    restBuilder => { restBuilder.AddSwagger(options => { options.SwaggerGenDemoMode(); }); });

            //builder.Services.AddServices(config);
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context,
        IOptions<AppSettings> settings)
    {
        RestApiBuilderExtensions.Configure(app, env, settings);
    }
}