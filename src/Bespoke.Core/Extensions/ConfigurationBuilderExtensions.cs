﻿using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;

namespace Bespoke.Core.Extensions;

[ExcludeFromCodeCoverage]
public static class ConfigurationBuilderExtensions
{
    public static IConfigurationBuilder AddEmbeddedJsonFile(this IConfigurationBuilder configurationBuilder,
        Assembly assembly, string name, bool optional = false, bool reloadOnChange = false)
    {
        // reload on change is not supported, always pass in false
        return configurationBuilder.AddJsonFile(new EmbeddedFileProvider(assembly), name, optional, reloadOnChange);
    }
}