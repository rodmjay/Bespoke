#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Security.Claims;
using IdentityPro.Shared.Models;

namespace IdentityPro.Services.Interfaces;

public interface IUserAccessor
{
    Task<UserDto> GetUser(ClaimsPrincipal principal);
}