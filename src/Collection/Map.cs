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

        public static List<TR> Map<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, TR> callback)
        {
            List<TR> result = new List<TR>();

            Each(dictionary, (v, k, d) =>
            {
                result.Add(callback(v, k, d));
            });

            return result;
        }

        public static List<TR> Map<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TK, TR> callback)
        {
            return Map(dictionary, (v, k, d) => callback(v, k));
        }

        public static List<TR> Map<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TR> callback)
        {
            return Map(dictionary, (v, k, d) => callback(v));
        }

        public static List<TR> Map<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR> callback)
        {
            return Map(dictionary, (v, k, d) => callback());
        }

        public static List<TR> Map<TV, TR>(List<TV> list, Func<TV, int, List<TV>, TR> callback)
        {
            List<TR> result = new List<TR>();

            Each(list, (v, i, a) =>
            {
                result.Add(callback(v, i, a));
            });

            return result;
        }

        public static List<TR> Map<TV, TR>(List<TV> list, Func<TV, int, TR> callback)
        {
            return Map(list, (v, i, a) => callback(v, i));
        }

        public static List<TR> Map<TV, TR>(List<TV> list, Func<TV, TR> callback)
        {
            return Map(list, (v, i, a) => callback(v));
        }

        public static List<TR> Map<TV, TR>(List<TV> list, Func<TR> callback)
        {
            return Map(list, (v, i, a) => callback());
        }
    }
}
#pragma warning restore SA1300, SA1649
