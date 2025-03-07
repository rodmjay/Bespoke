#region Header Info

// Copyright 2024 BespokeTalent.  All rights reserved

#endregion

namespace Bespoke.Shared.Common;

public class ValidationError
{
    public string Field { get; set; }
    public IEnumerable<string> Errors { get; set; }
}