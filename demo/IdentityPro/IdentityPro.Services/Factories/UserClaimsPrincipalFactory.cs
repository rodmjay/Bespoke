﻿using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace IdentityPro.Services.Factories;

public class UserClaimsPrincipalFactory(
    UserManager<User> userManager,
    IOptions<IdentityOptions> optionsAccessor)
    : UserClaimsPrincipalFactory<User>(userManager, optionsAccessor)
{
    public override async Task<ClaimsPrincipal> CreateAsync(User user)
    {
        if (user == null) throw new ArgumentNullException(nameof(user));

        var id = await GenerateClaimsAsync(user);
        return new ClaimsPrincipal(id);
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
    {
        var id = new ClaimsIdentity(
            Constants.LocalIdentity.DefaultApplicationScheme, // todo: REVIEW: Used to match Application scheme
            Options.ClaimsIdentity.UserNameClaimType,
            Options.ClaimsIdentity.RoleClaimType);

        var userId = await UserManager.GetUserIdAsync(user);
        var userName = await UserManager.GetUserNameAsync(user);

        id.AddClaim(new Claim(Options.ClaimsIdentity.UserIdClaimType, userId));
        id.AddClaim(new Claim(Options.ClaimsIdentity.UserNameClaimType, userName));
        
        // Get the first organization ID if user has any organizations
        var organizationId = user.UserOrganizations.FirstOrDefault()?.OrganizationId.ToString() ?? "0";
        id.AddClaim(new Claim("organizationId", organizationId));

        if (UserManager.SupportsUserEmail)
        {
            var email = await UserManager.GetEmailAsync(user);
            if (!string.IsNullOrEmpty(email)) id.AddClaim(new Claim(Options.ClaimsIdentity.EmailClaimType, email));
        }

        if (UserManager.SupportsUserSecurityStamp)
            id.AddClaim(new Claim(Options.ClaimsIdentity.SecurityStampClaimType,
                await UserManager.GetSecurityStampAsync(user)));
        if (UserManager.SupportsUserClaim) id.AddClaims(await UserManager.GetClaimsAsync(user));

        return id;
    }
}
