﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace TechValley.Data.Interfaces;

public interface IMayHaveTenant
{
    /// <summary>TenantId of this entity.</summary>
    int? TenantId { get; set; }
}