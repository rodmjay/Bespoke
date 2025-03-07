using System.ComponentModel;
using System.Reflection;

namespace AssetScope.Shared.Extensions;

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

    public static string? GetDescription<TEnum>(TEnum enumValue) where TEnum : Enum
    {
        return typeof(TEnum).GetField(enumValue.ToString())
            ?.GetCustomAttribute<DescriptionAttribute>()
            ?.Description;
    }
}