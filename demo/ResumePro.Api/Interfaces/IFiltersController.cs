﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Api.Interfaces;

public interface IFiltersController
{
    Task<FilterContainer> GetFilters();
}