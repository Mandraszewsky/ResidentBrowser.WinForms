using System.ComponentModel;
using System.Reflection;

namespace ResidentBrowser.ApplicationLayer.Utilities;

public static class EnumHelper
{
    public static TEnum? GetEnumValueFromDescription<TEnum>(string description) where TEnum : Enum
    {
        foreach (var field in typeof(TEnum).GetFields())
        {
            var attribute = field.GetCustomAttribute<DescriptionAttribute>();

            if (attribute != null && attribute.Description.Equals(description, StringComparison.OrdinalIgnoreCase))
            {
                return (TEnum)field.GetValue(null);
            }
        }

        return default(TEnum);
    }

    public static string GetDescription<TEnum>(TEnum value) where TEnum : Enum
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();

        return attribute?.Description ?? value.ToString();
    }
}
