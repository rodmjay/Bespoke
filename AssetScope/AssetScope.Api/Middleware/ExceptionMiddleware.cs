using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using Bespoke.Core.Extensions;
using Bespoke.Shared.Common;
using Dawn;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace AssetScope.Api.Middleware;

public class ExceptionMiddleware(
    RequestDelegate next,
    ILoggerFactory loggerFactory,
    IOptions<MvcNewtonsoftJsonOptions> jsonOptions)
{
    private readonly JsonSerializerSettings _jsonSerializerSettings = jsonOptions.Value.SerializerSettings;


    private static string GetLogMessage(string message, [CallerMemberName] string? callerName = null)
    {
        return $"[{nameof(ExceptionMiddleware)}.{callerName}] - {message}";
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private static HttpStatusCode GetErrorCode(Exception e)
    {
        switch (e)
        {
            case AuthenticationException:
                return HttpStatusCode.Unauthorized;
            case ValidationException:
                return HttpStatusCode.BadRequest;
            case FormatException:
                return HttpStatusCode.BadRequest;
            case UnauthorizedAccessException:
                return HttpStatusCode.Forbidden;
            case NotImplementedException:
                return HttpStatusCode.NotImplemented;
            default:
                return HttpStatusCode.InternalServerError;
        }
    }

    private void LogAndAddException(Result modelResult, Exception exception)
    {
        Guard.Argument(exception)
            .NotNull();

        var exLogger = loggerFactory.CreateLogger(exception.TargetSite!.DeclaringType!.FullName!);
        exLogger?.LogError(exception, exception.Message);
        modelResult.Errors.Add(new Error
        {
            Code = GetErrorCode(exception).ToString(),
            Description = exception.Message
        });
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var modelResult = new Result();

        if (exception is AggregateException exceptions)
            foreach (var ex in exceptions.InnerExceptions)
                LogAndAddException(modelResult, ex);
        else
            LogAndAddException(modelResult, exception);

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)GetErrorCode(exception);

        return context.Response.WriteAsync(modelResult.ToJson(_jsonSerializerSettings));
    }
}