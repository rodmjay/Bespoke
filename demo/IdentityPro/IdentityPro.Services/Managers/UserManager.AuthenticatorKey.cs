﻿using Microsoft.AspNetCore.Identity;

namespace IdentityPro.Services.Managers;

public partial class UserManager
{
    public override async Task<IdentityResult> ResetAuthenticatorKeyAsync(User user)
    {
        ThrowIfDisposed();
        if (user == null) throw new ArgumentNullException(nameof(user));
        await _userService.SetAuthenticatorKeyAsync(user, GenerateNewAuthenticatorKey(), CancellationToken);
        await UpdateSecurityStampInternal(user);
        return await UpdateAsync(user);
    }

    public override string GenerateNewAuthenticatorKey()
    {
        return NewSecurityStamp();
    }

    public override Task<string> GetAuthenticatorKeyAsync(User user)
    {
        ThrowIfDisposed();
        if (user == null) throw new ArgumentNullException(nameof(user));
        return _userService.GetAuthenticatorKeyAsync(user, CancellationToken);
    }
}