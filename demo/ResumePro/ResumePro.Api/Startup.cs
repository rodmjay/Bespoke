using Bespoke.Azure.AppInsights.Extensions;
using Bespoke.Azure.BlobStorage;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Extensions;
using Bespoke.Core.Settings;
using Bespoke.Data.Extensions;
using Bespoke.Data.SQLite;
using Bespoke.Data.SqlServer;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Middleware;
using Bespoke.Rest.Swagger.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
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
        services.AddBespoke(Configuration, builder =>
        {
            builder
                .AddEventAggregator()
                .AddAutomapper()
                .AddStorage(
                    dbSettings =>
                    {
                        dbSettings.MigrationsAssembly = "ResumePro.Infrastructure.SQLite";
                        dbSettings.MaxRetryCount = 5;
                    },
                    dataBuilder =>
                    {
                        var useSQLite = Configuration.GetValue<bool>("AppSettings:UseSQLite");
                        
                        if (useSQLite)
                        {
                            dataBuilder.UseSQLite<ApplicationContext>(settings =>
                            {
                                settings.ConnectionStringName = "SQLiteConnection";
                            });
                        }
                        else
                        {
                            dataBuilder.UseSqlServer<ApplicationContext>(sqlSettings =>
                            {
                                sqlSettings.ConnectionStringName = "DefaultConnection";
                            });
                        }
                    }
                )
                .AddAzure(
                    azureSettings =>
                    {
                        azureSettings.UseAzureManagedIdentity = true;
                        azureSettings.AccountName = "MyAzureStorageAccount";
                        azureSettings.AccountKey = "SuperSecretKey";
                    },
                    azureBuilder =>
                    {
                        azureBuilder.AddAppInsights(
                            appInsightsSettings =>
                            {
                                appInsightsSettings.CloudRoleName = "RESUMEPRO";
                                appInsightsSettings.EnableAdaptiveSampling = true;
                                appInsightsSettings.EnableDependencyTrackingTelemetryModule = false;
                            });
                        azureBuilder.AddBlobStorage();
                    })
                .AddRest(restSettings => { restSettings.Cors.AllowAnyOrigin = true; },
                    restBuilder => { restBuilder.AddSwagger(options => { options.SwaggerGenDemoMode(); }); });


            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/account/login";
                    options.LoginPath = "/account/logout";
                });
            builder.Services.AddAuthorization();

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

        var appSettings = settings.Value;

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseHsts();
        }

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint($"/swagger/{settings.Value.Version}/swagger.json", appSettings.Name);
            c.RoutePrefix = "swagger"; // Changed from string.Empty to "swagger"
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
