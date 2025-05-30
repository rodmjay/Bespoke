﻿using System.Security.Claims;
using IdentityPro.Services.Managers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace IdentityPro.Services.Factories;

public class UserRoleClaimsPrincipalFactory(
    UserManager userManager,
    RoleManager roleManager,
    IOptions<IdentityOptions> optionsAccessor)
    : UserClaimsPrincipalFactory(userManager, optionsAccessor)
{
    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
    {
        var id = await base.GenerateClaimsAsync(user);

        if (userManager.SupportsUserRole)
        {
            var roles = await userManager.GetRolesAsync(user);
            foreach (var roleName in roles)
            {
                id.AddClaim(new Claim(Options.ClaimsIdentity.RoleClaimType, roleName));
                if (roleManager.SupportsRoleClaims)
                {
                    var role = await roleManager.FindByNameAsync(roleName);
                    if (role != null) id.AddClaims(await roleManager.GetClaimsAsync(role));
                }
            }
        }

        return id;
    }
}