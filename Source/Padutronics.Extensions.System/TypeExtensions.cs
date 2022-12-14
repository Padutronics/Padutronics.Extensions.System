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

    public static ConstructorInfo? GetDefaultConstructor(this Type @this)
    {
        return @this.GetConstructor(Type.EmptyTypes);
    }

    public static MethodInfo? GetMethod<T>(this Type @this, string name)
    {
        return @this.GetMethod(name, new[] { typeof(T) });
    }

    public static MethodInfo? GetMethod<T1, T2>(this Type @this, string name)
    {
        return @this.GetMethod(name, new[] { typeof(T1), typeof(T2) });
    }

    public static MethodInfo? GetMethod<T1, T2, T3>(this Type @this, string name)
    {
        return @this.GetMethod(name, new[] { typeof(T1), typeof(T2), typeof(T3) });
    }

    public static MethodInfo? GetMethod<T1, T2, T3, T4>(this Type @this, string name)
    {
        return @this.GetMethod(name, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
    }

    public static MethodInfo? GetMethod<T1, T2, T3, T4, T5>(this Type @this, string name)
    {
        return @this.GetMethod(name, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
    }
}