﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Security.Claims;

namespace Bespoke.Users.Interfaces;

public interface IUserAccessor
{
    Task<UserOutput> GetUser(ClaimsPrincipal principal);
}