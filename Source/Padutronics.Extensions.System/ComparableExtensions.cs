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

    public static bool IsInRange<T>(this T @this, T inclusiveLowerBound, T inclusiveUpperBound)
        where T : IComparable<T>
    {
        return IsInRange(@this, inclusiveLowerBound, inclusiveUpperBound, isLowerBoundIncluded: true, isUpperBoundIncluded: true);
    }

    public static bool IsInRange<T>(this T @this, T lowerBound, T upperBound, bool isLowerBoundIncluded, bool isUpperBoundIncluded)
        where T : IComparable<T>
    {
        bool isLowerBoundValid = isLowerBoundIncluded ? @this.CompareTo(lowerBound) >= 0 : @this.CompareTo(lowerBound) > 0;
        bool isUpperBoundValid = isUpperBoundIncluded ? @this.CompareTo(upperBound) <= 0 : @this.CompareTo(upperBound) < 0;

        return isLowerBoundValid && isUpperBoundValid;
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