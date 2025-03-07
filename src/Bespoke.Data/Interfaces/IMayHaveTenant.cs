#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Data.Interfaces;

public interface IMayHaveTenant
{
    /// <summary>TenantId of this entity.</summary>
    int? TenantId { get; set; }
}