namespace IdentityPro.Shared.Interfaces
{
    public interface IRoleClaim
    {
        int Id { get; set; }
        string ClaimType { get; set; }
        string ClaimValue { get; set; }
        // Add any additional properties required
    }
}
