#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace TechValley.Core.Helpers;

public static class ConfigurationHelper
{

    public static T ConfigureSettings<T>(this (IConfiguration, IServiceCollection) builder, string name, Action<T> modifySettings = null) where T : class, new()
    {
        // Retrieve the settings from the configuration
        var settingsInstance = builder.Item1.GetSection(name).Get<T>() ?? new T();

        // Apply modifications to the settings if provided
        modifySettings?.Invoke(settingsInstance);

        // Register the modified settings in DI as IOptions<T>
        builder.Item2.AddSingleton<IOptions<T>>(new OptionsWrapper<T>(settingsInstance));

        // Register options with validation in the Options Pattern and bind to the configuration
        builder.Item2.AddOptions<T>()
            .Bind(builder.Item1.GetSection(name))
            .ValidateDataAnnotations();

        // Return the options instance (wrapped)
        return new OptionsWrapper<T>(settingsInstance).Value;
    }

}