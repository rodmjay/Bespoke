using AgencyPro.Shared.Extensions;

namespace AgencyPro.Api.Middleware;

public class LiveModeMiddleware
{
}

public class DemoModeMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IServiceProvider _serviceProvider;

    public DemoModeMiddleware(RequestDelegate next, IServiceProvider serviceProvider)
    {
        _next = next;
        _serviceProvider = serviceProvider;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Try to get the User ID from the header
        if (!context.Request.Headers.TryGetValue("X-User-Id", out var userIdValue) ||
            !int.TryParse(userIdValue, out var userId))
            // Default to User ID = 1 if header is missing or invalid
            userId = 1;

        // Create a scope for resolving services
        using var scope = _serviceProvider.CreateScope();

        //todo: fix this
        //var agencyService = scope.ServiceProvider.GetRequiredService<IAgencyService>();

        // Fetch the user object
        var user = new UserInfo();

        if (user != null)
        {
            // Store the user object in HttpContext.Items
            context.Items["User"] = user;
            context.User = ClaimsPrincipalFactory.Create(user);
        }

        await _next(context);
    }
}