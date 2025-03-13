namespace IdentityPro.Shared.Interfaces
{
    public interface IUserLogin
    {
        string LoginProvider { get; set; }
        string ProviderKey { get; set; }
        // Add any additional properties required
    }
}
