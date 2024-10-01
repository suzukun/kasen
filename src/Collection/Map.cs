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
            List<T> result = new();

            Each(size, (i) =>
            {
                result.Add(callback(i));
            });

            return result;
        }

        public static List<TR> Map<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TV, TK, TR> callback)
        {
            List<TR> result = new();

            Each(dictionary, (v, k) =>
            {
                result.Add(callback(v, k));
            });

            return result;
        }

        public static List<TR> Map<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TV, TR> callback)
        {
            return Map(dictionary, (v, k) => callback(v));
        }

        public static List<TR> Map<TV, TR>(IList<TV> list, Func<TV, int, TR> callback)
        {
            List<TR> result = new();

            Each(list, (v, i) =>
            {
                result.Add(callback(v, i));
            });

            return result;
        }

        public static List<TR> Map<TV, TR>(IList<TV> list, Func<TV, TR> callback)
        {
            return Map(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
