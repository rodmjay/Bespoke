namespace Bespoke.Shared.Interfaces;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
}