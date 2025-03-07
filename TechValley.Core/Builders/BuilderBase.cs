#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechValley.Core.Builders;

public abstract class BuilderBase : IBuilder
{
    protected BuilderBase(IBuilder builder)
    {
        this.Services = builder.Services;
        this.Configuration = builder.Configuration;
    }

    public IServiceCollection Services { get; }
    public IConfiguration Configuration { get; }


    public (IConfiguration, IServiceCollection) GetAppBuilder()
    {
        return (Configuration, Services);
    }
}