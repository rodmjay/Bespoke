using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Bespoke.Rest.Swagger;

public class FileWithOptionsOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (operation.OperationId != "AddAttachment") // Use your action's OperationId
            return;

        operation.RequestBody = new OpenApiRequestBody
        {
            Content = new Dictionary<string, OpenApiMediaType>
            {
                ["multipart/form-data"] = new()
                {
                    Schema = new OpenApiSchema
                    {
                        Type = "object",
                        Properties = new Dictionary<string, OpenApiSchema>
                        {
                            ["file"] = new()
                            {
                                Type = "string",
                                Format = "binary",
                                Description = "File to upload"
                            },
                            ["options"] = new()
                            {
                                Type = "object",
                                Properties = new Dictionary<string, OpenApiSchema>
                                {
                                    ["name"] = new() { Type = "string" },
                                    ["description"] = new() { Type = "string" }
                                },
                                Description = "Attachment options in JSON format"
                            }
                        },
                        Required = new HashSet<string> { "file", "options" }
                    }
                }
            }
        };
    }
}