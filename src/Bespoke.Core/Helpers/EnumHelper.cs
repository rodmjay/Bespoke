#nullable enable

using System.ComponentModel;
using System.Reflection;

namespace Bespoke.Core.Helpers;

public static class EnumHelper
{
    public static Dictionary<string, int> GetEnumValuesWithDescriptions<TEnum>() where TEnum : Enum
    {
        return Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .ToDictionary(
                e => GetDescription(e) ?? e.ToString(),
                e => Convert.ToInt32(e)
            );
    }

    private static string? GetDescription<TEnum>(TEnum enumValue) where TEnum : Enum
    {
        return typeof(TEnum).GetField(enumValue.ToString())
            ?.GetCustomAttribute<DescriptionAttribute>()
            ?.Description;
    }
}