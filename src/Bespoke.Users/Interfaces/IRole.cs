﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Users.Interfaces;

public interface IRole
{
    string Name { get; set; }
    int Id { get; set; }
}