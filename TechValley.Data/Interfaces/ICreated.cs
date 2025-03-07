﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace TechValley.Data.Interfaces;

public interface ICreated
{
    DateTimeOffset Created { get; set; }
}