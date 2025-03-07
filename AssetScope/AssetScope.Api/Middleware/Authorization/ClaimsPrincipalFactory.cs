using System.Security.Claims;
using AssetScope.Shared.Models;

namespace AssetScope.Api.Middleware.Authorization;

// A factory class to create a ClaimsPrincipal object, which represents the security context of the user (identity and claims).
public class ClaimsPrincipalFactory
{
    // This method generates a ClaimsPrincipal object for a given user.
    // Parameters:
    // - UserInfo user: An object representing the user's details (e.g., ID, email, roles, and rights).
    // - string type: The authentication type, defaulting to "Custom".
    public static ClaimsPrincipal Create(UserInfo user, string type = "Custom")
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.Email)
        };

        if (user.Roles != null) claims.AddRange(user.Roles.Select(role => new Claim(ClaimTypes.Role, role.ToString())));

        foreach (var property in user.GetType().GetProperties())
            if (property.PropertyType == typeof(bool) && (bool)property.GetValue(user)!)
                if (ClaimsConfiguration.RightsToClaimsMap.TryGetValue(property.Name, out var mappedClaims))
                    claims.AddRange(mappedClaims);

        var identity = new ClaimsIdentity(claims, type);
        return new ClaimsPrincipal(identity);
    }
}