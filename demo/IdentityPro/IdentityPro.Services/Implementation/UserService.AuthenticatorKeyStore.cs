namespace IdentityPro.Services.Implementation;

public partial class UserService
{
    public Task SetAuthenticatorKeyAsync(User user, string key, CancellationToken cancellationToken)
    {
        return SetTokenAsync(user, InternalLoginProvider, AuthenticatorKeyTokenName, key, cancellationToken);
    }

    public Task<string> GetAuthenticatorKeyAsync(User user, CancellationToken cancellationToken)
    {
        return GetTokenAsync(user, InternalLoginProvider, AuthenticatorKeyTokenName, cancellationToken);
    }
}