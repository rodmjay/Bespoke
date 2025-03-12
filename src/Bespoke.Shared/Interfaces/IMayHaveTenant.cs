namespace Bespoke.Shared.Interfaces;

public interface IMayHaveTenant
{
    /// <summary>TenantId of this entity.</summary>
    int? TenantId { get; set; }
}