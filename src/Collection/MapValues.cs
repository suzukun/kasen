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
        public static Dictionary<int, T> MapValues<T>(int size, Func<int, T> callback)
        {
            Dictionary<int, T> result = new();

            Each(size, (i) =>
            {
                result.Add(i, callback(i));
            });

            return result;
        }

        public static Dictionary<TK, TR> MapValues<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TV, TK, TR> callback)
        {
            Dictionary<TK, TR> result = new();

            Each(dictionary, (v, k) =>
            {
                result.Add(k, callback(v, k));
            });

            return result;
        }

        public static Dictionary<TK, TR> MapValues<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TV, TR> callback)
        {
            return MapValues(dictionary, (v, k) => callback(v));
        }

        public static Dictionary<int, TR> MapValues<TV, TR>(IList<TV> list, Func<TV, int, TR> callback)
        {
            Dictionary<int, TR> result = new();

            Each(list, (v, i) =>
            {
                result.Add(i, callback(v, i));
            });

            return result;
        }

        public static Dictionary<int, TR> MapValues<TV, TR>(IList<TV> list, Func<TV, TR> callback)
        {
            return MapValues(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
