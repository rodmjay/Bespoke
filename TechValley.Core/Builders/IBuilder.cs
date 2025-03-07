#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechValley.Core.Builders;

public interface IBuilder
{
    IServiceCollection Services { get; }
    IConfiguration Configuration { get; }
}