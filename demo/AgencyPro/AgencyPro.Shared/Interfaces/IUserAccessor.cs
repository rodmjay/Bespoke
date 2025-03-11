#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Security.Claims;

namespace AgencyPro.Shared.Interfaces;

public interface IUserAccessor
{
    Task<IUser> GetUser(ClaimsPrincipal principal);
}