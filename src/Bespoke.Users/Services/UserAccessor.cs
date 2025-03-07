#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Security.Claims;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Bespoke.Services.Bases;
using Bespoke.Users.Managers;

namespace Bespoke.Users.Services;

public class UserAccessor(
    UserManager userManager,
    IServiceProvider serviceProvider)
    : BaseService<User>(serviceProvider), IUserAccessor
{
    public Task<UserOutput> GetUser(ClaimsPrincipal principal)
    {
        var id = userManager.GetUserId(principal);

        var userId = int.Parse(id);

        return userManager.Users.Where(x => x.Id == userId)
            .ProjectTo<UserOutput>(ProjectionMapping)
            .FirstOrDefaultAsync();
    }
}