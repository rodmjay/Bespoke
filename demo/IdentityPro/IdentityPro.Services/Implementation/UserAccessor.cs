#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Security.Claims;
using AutoMapper.QueryableExtensions;
using Bespoke.Services.Bases;
using IdentityPro.Services.Managers;
using IdentityPro.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityPro.Services.Implementation;

public class UserAccessor(
    UserManager userManager,
    IServiceProvider serviceProvider)
    : BaseService<User>(serviceProvider), IUserAccessor
{
    public Task<UserDto> GetUser(ClaimsPrincipal principal)
    {
        var id = userManager.GetUserId(principal);

        var userId = int.Parse(id);

        return userManager.Users.Where(x => x.Id == userId)
            .ProjectTo<UserDto>(ProjectionMapping)
            .FirstAsync();
    }
}