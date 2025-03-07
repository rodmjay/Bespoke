﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Bespoke.Core.Settings;

public static class JsonSettings
{
    public static JsonSerializerSettings Settings => new()
    {
        ContractResolver = new CamelCasePropertyNamesContractResolver(),
        Formatting = Formatting.Indented,
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        NullValueHandling = NullValueHandling.Include,
        DateFormatString = "yyyy-MM-dd"
    };
}