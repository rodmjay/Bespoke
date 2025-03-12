using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Bespoke.Rest.Swagger.Extensions;

public static class SwaggerGenOptionsExtensions
{
    public static void SwaggerGenDemoMode(this SwaggerGenOptions options, string userIdHeader = "X-User-Id")
    {
        options.AddSecurityDefinition(userIdHeader, new OpenApiSecurityScheme
        {
            Name = userIdHeader, // Name of the header
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
                        Id = userIdHeader
                    }
                },
                Array.Empty<string>()
            }
        });
    }
}