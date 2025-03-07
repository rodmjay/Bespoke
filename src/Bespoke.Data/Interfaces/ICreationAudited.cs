#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Data.Interfaces;

public interface ICreationAudited : IHasCreationTime
{
    /// <summary>Id of the creator user of this entity.</summary>
    long? CreatorUserId { get; set; }
}