#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Data.Interfaces;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
}