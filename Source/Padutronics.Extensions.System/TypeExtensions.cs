using System;
using System.Reflection;

namespace Padutronics.Extensions.System;

public static class TypeExtensions
{
    public static ConstructorInfo? GetConstructor<T>(this Type @this)
    {
        return @this.GetConstructor(new[] { typeof(T) });
    }

    public static ConstructorInfo? GetConstructor<T1, T2>(this Type @this)
    {
        return @this.GetConstructor(new[] { typeof(T1), typeof(T2) });
    }

    public static ConstructorInfo? GetConstructor<T1, T2, T3>(this Type @this)
    {
        return @this.GetConstructor(new[] { typeof(T1), typeof(T2), typeof(T3) });
    }

    public static ConstructorInfo? GetConstructor<T1, T2, T3, T4>(this Type @this)
    {
        return @this.GetConstructor(new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
    }

    public static ConstructorInfo? GetConstructor<T1, T2, T3, T4, T5>(this Type @this)
    {
        return @this.GetConstructor(new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
    }
}