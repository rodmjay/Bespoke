﻿using Bespoke.Azure.AppInsights.Extensions;
using Bespoke.Azure.BlobStorage;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Extensions;
using Bespoke.Core.Settings;
using Bespoke.Data.Extensions;
using Bespoke.Data.SqlServer;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Middleware;
using Bespoke.Rest.Swagger.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using ResumePro.Api.Services;
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
                        dbSettings.MigrationsAssembly = "ResumePro.Infrastructure.SqlServer";
                        dbSettings.MaxRetryCount = 5;
                    },
                    dataBuilder =>
                    {
                        dataBuilder.UseSqlServer<ApplicationContext>(sqlSettings =>
                        {
                            sqlSettings.ConnectionStringName = "DefaultConnection";
                        });
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
            
            // Add health checks for PostgreSQL
            builder.Services.AddHealthChecks()
                .AddNpgSql(Configuration.GetConnectionString("PostgreSQLConnection") ?? 
                    throw new InvalidOperationException("PostgreSQLConnection string is not configured."), 
                    name: "postgres", 
                    tags: new[] { "database" });
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
        IOptions<AppSettings> settings, IHostApplicationLifetime appLifetime)
    {
        app.UseMiddleware<ExceptionMiddleware>();

        var appSettings = settings.Value;

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            
            // Start the Angular app in development mode if the service is available
            var angularAppService = app.ApplicationServices.GetService<AngularAppService>();
            if (angularAppService != null)
            {
                angularAppService.StartAngularApp();
                
                // Register for application shutdown to dispose the Angular process
                appLifetime.ApplicationStopping.Register(() =>
                {
                    angularAppService.Dispose();
                });
            }
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
        
        // Add CORS middleware
        app.UseCors(builder => 
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader());

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHealthChecks("/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
            {
                ResponseWriter = async (context, report) =>
                {
                    context.Response.ContentType = "application/json";
                    context.Response.Headers.Append("Access-Control-Allow-Origin", "*");
                    
                    var result = System.Text.Json.JsonSerializer.Serialize(new
                    {
                        status = report.Status.ToString(),
                        checks = report.Entries.Select(e => new { name = e.Key, status = e.Value.Status.ToString() })
                    });
                    
                    await context.Response.WriteAsync(result);
                }
            });
        });
    }
}
