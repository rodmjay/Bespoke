using AssetScope.Services.Interfaces;
using AssetScope.Shared.Models;

namespace AssetScope.Api.Middleware.Authorization;

public class TestModeAuthorizationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IServiceProvider _serviceProvider;

    public TestModeAuthorizationMiddleware(RequestDelegate next, IServiceProvider serviceProvider)
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

        // Resolve the AgencyService from the DI container
        using var scope = _serviceProvider.CreateScope();
        var agencyService = scope.ServiceProvider.GetRequiredService<IAgencyService>();

        // Fetch the user object
        var user = await agencyService.GetUser<UserInfo>(userId);

        if (user != null)
        {
            // Store the user object in HttpContext.Items
            context.Items["User"] = user;
            context.User = ClaimsPrincipalFactory.Create(user);
        }

        await _next(context);
    }
}