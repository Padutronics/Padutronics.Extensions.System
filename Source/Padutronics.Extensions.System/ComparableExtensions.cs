using System;

namespace Padutronics.Extensions.System;

public static class ComparableExtensions
{
    public static bool IsEqualTo<T>(this T @this, T expectedValue)
        where T : IComparable<T>
    {
        return @this.CompareTo(expectedValue) == 0;
    }

    public static bool IsGreaterThan<T>(this T @this, T lowerBound)
        where T : IComparable<T>
    {
        return @this.CompareTo(lowerBound) > 0;
    }

    public static bool IsGreaterThanOrEqualTo<T>(this T @this, T lowerBound)
        where T : IComparable<T>
    {
        return @this.CompareTo(lowerBound) >= 0;
    }

    public static bool IsLessThan<T>(this T @this, T upperBound)
        where T : IComparable<T>
    {
        return @this.CompareTo(upperBound) < 0;
    }

    public static bool IsLessThanOrEqualTo<T>(this T @this, T upperBound)
        where T : IComparable<T>
    {
        return @this.CompareTo(upperBound) <= 0;
    }
}