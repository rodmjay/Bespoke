namespace Bespoke.Shared.Interfaces;

public interface IConcurrencyTracked
{
    string ConcurrencyStamp { get; set; }
}