#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<T> Map<T>(int size, Func<int, T> callback)
        {
            List<T> result = new List<T>();

            Each(size, (i) =>
            {
                result.Add(callback(i));
            });

            return result;
        }

        public static List<T> Map<T>(int size, Func<T> callback)
        {
            return Map(size, (i) => callback());
        }

        public static List<TV> Map<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, TV> callback)
        {
            List<TV> result = new List<TV>();

            Each(dictionary, (v, k, d) =>
            {
                result.Add(callback(v, k, d));
            });

            return result;
        }

        public static List<TV> Map<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, TV> callback)
        {
            return Map(dictionary, (v, k, d) => callback(v, k));
        }

        public static List<TV> Map<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TV> callback)
        {
            return Map(dictionary, (v, k, d) => callback(v));
        }

        public static List<TV> Map<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV> callback)
        {
            return Map(dictionary, (v, k, d) => callback());
        }

        public static List<T> Map<T>(List<T> list, Func<T, int, List<T>, T> callback)
        {
            List<T> result = new List<T>();

            Each(list, (v, i, a) =>
            {
                result.Add(callback(v, i, a));
            });

            return result;
        }

        public static List<T> Map<T>(List<T> list, Func<T, int, T> callback)
        {
            return Map(list, (v, i, a) => callback(v, i));
        }

        public static List<T> Map<T>(List<T> list, Func<T, T> callback)
        {
            return Map(list, (v, i, a) => callback(v));
        }

        public static List<T> Map<T>(List<T> list, Func<T> callback)
        {
            return Map(list, (v, i, a) => callback());
        }
    }
}
#pragma warning restore SA1300, SA1649
