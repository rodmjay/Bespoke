using AssetScope.Api.Middleware;
using AssetScope.Data.Contexts;
using Bespoke.Core.Extensions;
using Bespoke.Core.Settings;
using Bespoke.Data.Extensions;
using Bespoke.Data.SqlServer;
using Bespoke.Rest.Extensions;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace AssetScope.Api;

public sealed class Startup(
    IConfiguration configuration)
{
    public IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCompositeRoot(Configuration, builder =>
        {
            builder
                .AddAutomapper()
                .AddStorage(storageBuilder => { storageBuilder.UseSqlServer<ApplicationContext>(); })
                .AddRest(restBuilder =>
                {
                    restBuilder.AddSwagger(options =>
                    {
                        // Add a security definition for the header
                        options.AddSecurityDefinition("X-User-Id", new OpenApiSecurityScheme
                        {
                            Name = "X-User-Id", // Name of the header
                            In = ParameterLocation.Header, // Location of the header
                            Type = SecuritySchemeType.ApiKey, // Specify it's a header
                            Description = "Custom header to pass the User ID"
                        });

                        options.AddSecurityRequirement(new OpenApiSecurityRequirement
                        {
                            {
                                new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "X-User-Id"
                                    }
                                },
                                Array.Empty<string>()
                            }
                        });
                    });
                    //restBuilder.AddRoleBasedAuth();
                });
        });

        //services.AddServices(Configuration);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context,
        IOptions<AppSettings> settings)
    {
        app.UseMiddleware<ExceptionMiddleware>();
        //app.UseMiddleware<TestModeAuthorizationMiddleware>();

        RestApiBuilderExtensions.Configure(app, env, settings);
    }
}