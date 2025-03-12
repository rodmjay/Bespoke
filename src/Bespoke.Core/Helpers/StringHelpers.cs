namespace Bespoke.Core.Helpers;

public static class StringHelpers
{
    public static bool IsAscii(this string str)
    {
        foreach (var c in str)
            if (c > 127)
                return false;

        return true;
    }
}