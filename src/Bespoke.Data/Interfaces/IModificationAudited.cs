#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Data.Interfaces;

public interface IModificationAudited : IHasModificationTime
{
    /// <summary>Last modifier user for this entity.</summary>
    int? LastModifierUserId { get; set; }
}