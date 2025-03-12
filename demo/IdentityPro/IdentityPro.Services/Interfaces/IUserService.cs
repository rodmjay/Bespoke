#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.Services.Interfaces;
using IdentityPro.Shared.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityPro.Services.Interfaces;

public interface IUserService : IService<User>,
    IQueryableUserStore<User>,
    IUserPasswordStore<User>,
    IUserRoleStore<User>,
    IUserClaimStore<User>,
    IUserLoginStore<User>,
    IUserLockoutStore<User>,
    IUserPhoneNumberStore<User>,
    IUserEmailStore<User>,
    IUserAuthenticatorKeyStore<User>,
    IUserTwoFactorStore<User>,
    IUserTwoFactorRecoveryCodeStore<User>,
    IUserSecurityStampStore<User>,
    IUserAuthenticationTokenStore<User>
{
    Task<T> GetUserById<T>(int id) where T : UserDto;
}