#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Core.Builders;

public class AppBuilder : IBuilder
{
    public AppBuilder(IServiceCollection services,
        AppSettings settings,
        IConfiguration configuration)
    {
        Services = services;
        Configuration = configuration;
        AppSettings = settings;
    }

    public IServiceCollection Services { get; }
    public IConfiguration Configuration { get; }
    public AppSettings AppSettings { get; set; }

    public IServiceProvider Build()
    {
        return Services.BuildServiceProvider();
    }
}