using System;

namespace Padutronics.Extensions.System;

public static class ComparableExtensions
{
    public static bool IsEqualTo<T>(this T @this, T expectedValue)
        where T : IComparable<T>
    {
        return @this.CompareTo(expectedValue) == 0;
    }
}