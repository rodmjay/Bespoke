using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Serilog.Core;
using Serilog.Events;

namespace Bespoke.Core.Serilog.Enrichers;

public class ClaimsPrincipalEnricher : ILogEventEnricher
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ClaimsPrincipalEnricher(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext?.User?.Identity?.IsAuthenticated == true)
        {
            var id = httpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var userProperty = propertyFactory.CreateProperty("User", id);
            logEvent.AddPropertyIfAbsent(userProperty);
        }
        else
        {
            var userProperty = propertyFactory.CreateProperty("User", "SYSTEM");
            logEvent.AddPropertyIfAbsent(userProperty);
        }
    }
}