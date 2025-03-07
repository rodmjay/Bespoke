#region Header Info

// Copyright 2024 BespokeTalent.  All rights reserved

#endregion

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Bespoke.Core.Settings;

namespace Bespoke.IntegrationTesting.Extensions;

public static class HttpContentExtensions
{
    public static T DeserializeObject<T>(this HttpContent content)
    {
        var settings = JsonSettings.Settings;

        var jsonContent = content.ReadAsStringAsync().Result;

        var obj = JsonConvert.DeserializeObject<T>(jsonContent, settings);
        return obj;
    }
}
