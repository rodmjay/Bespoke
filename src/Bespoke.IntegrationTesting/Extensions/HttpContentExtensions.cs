using Bespoke.Core.Settings;
using Newtonsoft.Json;

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