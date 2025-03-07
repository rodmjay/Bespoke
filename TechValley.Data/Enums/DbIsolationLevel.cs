﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace TechValley.Data.Enums;

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