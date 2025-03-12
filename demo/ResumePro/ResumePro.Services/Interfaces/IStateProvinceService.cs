﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using ResumePro.Shared.Models;

namespace ResumePro.Services.Interfaces;

public interface IStateProvinceService
{
    Task<List<T>> GetStateProvincesForCountry<T>(string id) where T : StateProvinceOutput;
}