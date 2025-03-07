#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechValley.Core.Builders;

namespace TechValley.Rest.Builders;

public class RestApiBuilder(AppBuilder appBuilder, RestSettings restSettings) : IBuilder
{
    public IConfiguration Configuration => appBuilder.Configuration;

    public AppSettings AppSettings => appBuilder.AppSettings;
    public RestSettings RestSetings => restSettings;
    public IServiceCollection Services => appBuilder.Services;
}