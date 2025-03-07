#region Header Info

// Copyright 2024 TechValleyTalent.  All rights reserved

#endregion

namespace TechValley.Shared.Common;

public class ValidationError
{
    public string Field { get; set; }
    public IEnumerable<string> Errors { get; set; }
}