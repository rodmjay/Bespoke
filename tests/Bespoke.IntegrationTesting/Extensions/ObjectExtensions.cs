﻿#region Header Info

// Copyright 2024 BespokeTalent.  All rights reserved

#endregion

using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bespoke.IntegrationTesting.Extensions;

public static class ObjectExtensions
{
    public static StringContent SerializeToUTF8Json(this object model)
    {
        var str = JsonConvert.SerializeObject(model);

        return new StringContent(str,
            Encoding.UTF8, "application/json");
    }
}
