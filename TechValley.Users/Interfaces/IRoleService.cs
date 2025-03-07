﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.AspNetCore.Identity;
using TechValley.Services.Interfaces;

namespace TechValley.Users.Interfaces;

public interface IRoleService : IService<Role>,
    IRoleStore<Role>,
    IQueryableRoleStore<Role>,
    IRoleClaimStore<Role>
{
}