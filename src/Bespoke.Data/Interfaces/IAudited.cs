﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Data.Interfaces;

public interface IAudited :
    ICreationAudited,
    IModificationAudited
{
}