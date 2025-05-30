﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Bespoke.Rest.Swagger;

public class LowercaseDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        ////////	PATHS

        var paths = swaggerDoc.Paths;

        //	generate the new keys
        var newPaths = new Dictionary<string, OpenApiPathItem>();
        var removeKeys = new List<string>();
        foreach (var path in paths)
        {
            var newKey = path.Key.ToLower();
            if (newKey != path.Key)
            {
                removeKeys.Add(path.Key);
                newPaths.Add(newKey, path.Value);
            }
        }

        //	add the new keys
        foreach (var path in newPaths) swaggerDoc.Paths.Add(path.Key, path.Value);

        //	remove the old keys
        foreach (var key in removeKeys) swaggerDoc.Paths.Remove(key);
    }
}