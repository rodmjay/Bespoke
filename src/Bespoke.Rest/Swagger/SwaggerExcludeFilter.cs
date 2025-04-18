﻿using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Bespoke.Rest.Swagger;

[ExcludeFromCodeCoverage]
public class SwaggerExcludeFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (schema?.Properties == null || context.Type == null)
            return;

        var excludedProperties = context.Type.GetProperties()
            .Where(t =>
                t.GetCustomAttribute<JsonIgnoreAttribute>(true)
                != null);

        foreach (var excludedProperty in excludedProperties)
            if (schema.Properties.ContainsKey(excludedProperty.Name))
                schema.Properties.Remove(excludedProperty.Name);
    }
}