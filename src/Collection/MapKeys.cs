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
        public static Dictionary<T, int> MapKeys<T>(int size, Func<int, T> callback)
        {
            Dictionary<T, int> result = new();

            Each(size, (i) =>
            {
                Set(result, callback(i), i);
            });

            return result;
        }

        public static Dictionary<TR, TV> MapKeys<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TV, TK, TR> callback)
        {
            Dictionary<TR, TV> result = new();

            Each(dictionary, (v, k) =>
            {
                Set(result, callback(v, k), v);
            });

            return result;
        }

        public static Dictionary<TR, TV> MapKeys<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TV, TR> callback)
        {
            return MapKeys(dictionary, (v, k) => callback(v));
        }

        public static Dictionary<TR, TV> MapKeys<TV, TR>(IList<TV> list, Func<TV, int, TR> callback)
        {
            Dictionary<TR, TV> result = new();

            Each(list, (v, i) =>
            {
                Set(result, callback(v, i), v);
            });

            return result;
        }

        public static Dictionary<TR, TV> MapKeys<TV, TR>(IList<TV> list, Func<TV, TR> callback)
        {
            return MapKeys(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
