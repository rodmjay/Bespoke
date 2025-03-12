#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityPro.Services.Interfaces;

public interface IRoleService : IService<Role>,
    IRoleStore<Role>,
    IQueryableRoleStore<Role>,
    IRoleClaimStore<Role>
{
}