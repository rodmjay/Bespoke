namespace Bespoke.Shared.Interfaces;

public interface IModified
{
    /// <summary>The last modified time for this entity.</summary>
    DateTime? Updated { get; set; }
}