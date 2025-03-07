#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Security.Claims;
using Duende.IdentityServer;
using Duende.IdentityServer.Extensions;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;
using TechValley.Users.Factories;
using TechValley.Users.Managers;

namespace TechValley.Users.IdentityServer.Services;

public class IdentityProfileService(
    UserManager userManager,
    UserRoleClaimsPrincipalFactory userClaimsFactory)
    : IProfileService
{
    public async Task GetProfileDataAsync(ProfileDataRequestContext context)
    {
        var sub = context.Subject.GetSubjectId();
        var user = await userManager.FindByIdAsync(sub);
        var principal = await userClaimsFactory.CreateAsync(user);

        var claims = principal.Claims.ToList();

        claims = claims
            .Where(claim => context.RequestedClaimTypes.Contains(claim.Type)).ToList();

        claims.Add(user.TwoFactorEnabled ? new Claim("amr", "mfa") : new Claim("amr", "pwd"));

        claims.Add(new Claim(IdentityServerConstants.StandardScopes.Email, user.Email));
        claims.Add(new Claim("organizationId", user.OrganizationId.ToString()));

        context.IssuedClaims = claims;
    }


    public async Task IsActiveAsync(IsActiveContext context)
    {
        var sub = context.Subject.GetSubjectId();
        var user = await userManager.FindByIdAsync(sub);
        context.IsActive = user != null;
    }
}