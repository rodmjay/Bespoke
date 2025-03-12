using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace IdentityPro.Services.Managers;

public partial class SignInManager
{
    public override async Task SignOutAsync()
    {
        await Context.SignOutAsync(Constants.LocalIdentity.DefaultApplicationScheme);
        await Context.SignOutAsync(Constants.LocalIdentity.DefaultExternalScheme);
        await Context.SignOutAsync(IdentityConstants.TwoFactorUserIdScheme);
    }
}