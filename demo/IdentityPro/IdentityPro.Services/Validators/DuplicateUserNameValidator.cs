#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.AspNetCore.Identity;

namespace IdentityPro.Services.Validators;

public class DuplicateUserNameValidator(IdentityErrorDescriber errors) : IUserValidator<User>
{
    public async Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
    {
        var userByEmail = await manager.FindByEmailAsync(user.NormalizedEmail);
        if (userByEmail != null) return IdentityResult.Failed(errors.DuplicateEmail(user.Email));
        return IdentityResult.Success;
    }
}