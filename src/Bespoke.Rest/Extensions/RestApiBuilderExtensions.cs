#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Bespoke.Rest.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Bespoke.Rest.Extensions;

[ExcludeFromCodeCoverage]
public static class RestApiBuilderExtensions
{
    private static bool _swaggerAdded;

    private static string GetLogMessage(string message, [CallerMemberName] string? callerName = null)
    {
        return $"[{nameof(RestApiBuilderExtensions)}.{callerName}] - {message}";
    }

    public static RestApiBuilder AddSwagger(this RestApiBuilder builder,
        Action<SwaggerGenOptions>? configureSwagger = default)
    {
        Log.Logger.Debug(GetLogMessage("Adding swagger"));
        _swaggerAdded = true;

        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = builder.AppSettings.Name
            });


            // Set the comments path for the Swagger JSON and UI.
            //var xmlFile = $"{assembly.GetName().Name}.xml";
            //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //c.IncludeXmlComments(xmlPath);
            c.SchemaFilter<SwaggerExcludeFilter>();
            c.DocumentFilter<LowercaseDocumentFilter>();

            configureSwagger?.Invoke(c);
        });
        builder.Services.AddEndpointsApiExplorer();

        return builder;
    }

    public static RestApiBuilder AddCors(this RestApiBuilder builder, params string[] origins)
    {
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(
                opts =>
                {
                    if (builder.RestSetings.Cors.AllowAnyOrigin)
                        opts.AllowAnyOrigin();
                    else
                        opts.WithOrigins(builder.RestSetings.Cors.AllowedOrigins);
                    opts.AllowAnyMethod();
                    opts.AllowAnyHeader();
                });
        });

        return builder;
    }

    public static void Configure(IApplicationBuilder app, IWebHostEnvironment env,
        IOptions<AppSettings> settings)
    {
        var appSettings = settings.Value;

        if (_swaggerAdded)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{settings.Value.Version}/swagger.json", appSettings.Name);
                c.RoutePrefix = "swagger"; // Changed from string.Empty to "swagger"
            });
        }

        // Serve Angular’s static files (index.html, etc.)
        app.UseDefaultFiles();
        app.UseStaticFiles();

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}