namespace Padutronics.Extensions.System;

public static class StringExtensions
{
    public static bool IsEmpty(this string @this)
    {
        return @this.Length == 0;
    }
}