namespace IdentityPro.Shared.Interfaces
{
    public interface IUserToken
    {
        int UserId { get; set; }
        string LoginProvider { get; set; }
        string Name { get; set; }
        string Value { get; set; }
        // Add any additional properties required
    }
}
