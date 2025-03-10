#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

#nullable enable

using System.Runtime.CompilerServices;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Bespoke.Core.Builders;
using Bespoke.Core.Helpers;
using Bespoke.Shared.Common;
using Microsoft.Extensions.Configuration;

namespace Bespoke.Rest.Extensions;

public static class AppBuilderExtensions
{
    private static string GetLogMessage(string message, [CallerMemberName] string? callerName = null)
    {
        return $"[{nameof(AppBuilderExtensions)}.{callerName}] - {message}";
    }
    
    public static RestApiBuilder AddAuthorization(this RestApiBuilder builder)
    {
        builder.AddAuthorization(policy =>
        {
            policy.RequireAuthenticatedUser();

            var scopes = builder.RestSetings.Authentication.Audience.Split(" ");
            foreach (var scope in scopes) policy.RequireClaim("scope", scope);
        });
        return builder;
    }

    public static RestApiBuilder AddAuthorization(this RestApiBuilder builder,
        Action<AuthorizationPolicyBuilder> action)
    {
        builder.Services.AddAuthorization(options => { options.AddPolicy("ApiScope", action); });

        return builder;
    }

    public static RestApiBuilder AddBearerAuthentication(this RestApiBuilder builder,
        Action<JwtBearerOptions>? action = default)
    {
        //builder.Services.AddSingleton<IClaimsTransformation, ClaimsTransformer>();
        builder.Services.AddAuthentication("Bearer")
            .AddJwtBearer("Bearer", action ?? (_ => { }));

        return builder;
    }

    public static RestApiBuilder AddBearerAuthentication(this RestApiBuilder builder, HttpMessageHandler handler)
    {
        builder.AddBearerAuthentication(options =>
        {
            options.RequireHttpsMetadata = false;
            options.Authority = builder.RestSetings.Authentication.Authority;
            options.Audience = builder.RestSetings.Authentication.Audience;

            if (handler != null)
                options.BackchannelHttpHandler = handler;

            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidAudience = builder.RestSetings.Authentication.Audience,
                ValidateIssuer = true,
                ValidIssuer = builder.RestSetings.Authentication.Authority,
                NameClaimType = ClaimTypes.NameIdentifier,
                RoleClaimType = ClaimTypes.Role
            };

            options.Events = new JwtBearerEvents
            {
                OnAuthenticationFailed = c =>
                {
                    var logger = c.HttpContext.RequestServices.GetRequiredService<ILogger<StartupBase>>();
                    logger.LogTrace("Authentication Failure");
                    return Task.FromResult(0);
                },
                OnTokenValidated = c =>
                {
                    var logger = c.HttpContext.RequestServices.GetRequiredService<ILogger<StartupBase>>();
                    logger.LogTrace("Authentication Success");
                    return Task.FromResult(0);
                }
            };
        });
        return builder;
    }
    public static AppBuilder AddRest(this AppBuilder builder,
            Action<RestSettings>? configureRestSettings = null,
            Action<RestApiBuilder>? configureRestApi = null)
    {
        Log.Logger.Debug(GetLogMessage("ConfigureRestServices"));

        // Register HTTP context services
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddScoped<HttpContextAccessor>();

        // Load RestSettings from configuration
        var restSettings = new RestSettings();
        builder.Configuration.GetSection("RestSettings").Bind(restSettings);

        // Allow modification of RestSettings before injection
        configureRestSettings?.Invoke(restSettings);

        // Register RestSettings in DI
        builder.Services.Configure<RestSettings>(options =>
        {
            options.Authentication = restSettings.Authentication;
            options.Cors = restSettings.Cors;
        });

        // Configure RestApiBuilder for REST services
        var restBuilder = new RestApiBuilder(builder, restSettings);
        configureRestApi?.Invoke(restBuilder);

        // Configure controllers and JSON settings
        builder.Services.AddControllers(options =>
        {
            options.EnableEndpointRouting = true;
        })
            .AddNewtonsoftJson(o =>
            {
                if (JsonSettings.Settings != null)
                {
                    o.SerializerSettings.Formatting = JsonSettings.Settings.Formatting;
                    o.SerializerSettings.NullValueHandling = JsonSettings.Settings.NullValueHandling;
                    o.SerializerSettings.Converters = JsonSettings.Settings.Converters;
                    o.SerializerSettings.DateFormatString = JsonSettings.Settings.DateFormatString;
                    o.SerializerSettings.ReferenceLoopHandling = JsonSettings.Settings.ReferenceLoopHandling;
                }
            })
            .ConfigureApiBehaviorOptions(o =>
            {
                o.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState
                        .Where(e => e.Value != null && e.Value.Errors.Count > 0)
                        .Select(e => new
                        {
                            Field = e.Key,
                            Errors = e.Value!.Errors.Select(x => x.ErrorMessage)
                        });

                    var result = new Result
                    {
                        ValidationErrors = errors.Select(e => new ValidationError
                        {
                            Field = e.Field,
                            Errors = e.Errors
                        }),
                        Message = "Validation Failed"
                    };

                    return new BadRequestObjectResult(result);
                };
            });

        return builder;
    }

    public static AppBuilder AddRest(this AppBuilder builder, Action<RestApiBuilder>? configure = default)
    {
        Log.Logger.Debug(GetLogMessage("ConfigureRestServices"));
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddScoped<HttpContextAccessor>();
        
        var restSettings = (builder.Configuration, builder.Services)
            .ConfigureSettings<RestSettings>("RestSettings");

        var restBuilder = new RestApiBuilder(builder, restSettings);
        configure?.Invoke(restBuilder);

        builder.Services.AddControllers(x =>
            {
                x.EnableEndpointRouting = true;
            })
            .AddNewtonsoftJson(o =>
            {
                if (JsonSettings.Settings != null)
                {
                    o.SerializerSettings.Formatting = JsonSettings.Settings.Formatting;
                    o.SerializerSettings.NullValueHandling = JsonSettings.Settings.NullValueHandling;
                    o.SerializerSettings.Converters = JsonSettings.Settings.Converters;
                    o.SerializerSettings.NullValueHandling = JsonSettings.Settings.NullValueHandling;
                    o.SerializerSettings.DateFormatString = JsonSettings.Settings.DateFormatString;
                    o.SerializerSettings.ReferenceLoopHandling = JsonSettings.Settings.ReferenceLoopHandling;
                }
            })
            .ConfigureApiBehaviorOptions(o =>
            {
                o.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState
                        .Where(e => e.Value != null && e.Value.Errors.Count > 0)
                        .Select(e => new
                        {
                            Field = e.Key,
                            Errors = e.Value!.Errors.Select(x => x.ErrorMessage)
                        });

                    var result = new Result
                    {
                        ValidationErrors = errors.Select(e => new ValidationError
                        {
                            Field = e.Field,
                            Errors = e.Errors
                        }),
                        Message = "Validation Failed"
                    };

                    return new BadRequestObjectResult(result);
                };
            });

        return builder;
    }

}
