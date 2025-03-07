﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace TechValley.Shared.Common;

public class RedirectResult
{
    public bool Succeeded { get; set; }
    public string RedirectUrl { get; set; }
}