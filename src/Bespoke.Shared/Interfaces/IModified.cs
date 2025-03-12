#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Shared.Interfaces;

public interface IModified
{
    /// <summary>The last modified time for this entity.</summary>
    DateTime? Updated { get; set; }
}