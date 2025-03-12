namespace Bespoke.Data.Enums;

public enum DbIsolationLevel
{
    Chaos,
    ReadCommitted,
    ReadUncommitted,
    RepeatableRead,
    Serializable,
    Snapshot,
    Unspecified
}