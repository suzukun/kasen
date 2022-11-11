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
            Dictionary<int, T> result = new Dictionary<int, T>();

            Each(size, (i) =>
            {
                result.Add(i, callback(i));
            });

            return result;
        }

        public static Dictionary<int, T> MapValues<T>(int size, Func<T> callback)
        {
            return MapValues(size, (i) => callback());
        }

        public static Dictionary<TK, TR> MapValues<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, TR> callback)
        {
            Dictionary<TK, TR> result = new Dictionary<TK, TR>();

            Each(dictionary, (v, k, d) =>
            {
                result.Add(k, callback(v, k, d));
            });

            return result;
        }

        public static Dictionary<TK, TR> MapValues<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TK, TR> callback)
        {
            return MapValues(dictionary, (v, k, d) => callback(v, k));
        }

        public static Dictionary<TK, TR> MapValues<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TR> callback)
        {
            return MapValues(dictionary, (v, k, d) => callback(v));
        }

        public static Dictionary<TK, TR> MapValues<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR> callback)
        {
            return MapValues(dictionary, (v, k, d) => callback());
        }

        public static Dictionary<int, TR> MapValues<TV, TR>(List<TV> list, Func<TV, int, List<TV>, TR> callback)
        {
            Dictionary<int, TR> result = new Dictionary<int, TR>();

            Each(list, (v, i, a) =>
            {
                result.Add(i, callback(v, i, a));
            });

            return result;
        }

        public static Dictionary<int, TR> MapValues<TV, TR>(List<TV> list, Func<TV, int, TR> callback)
        {
            return MapValues(list, (v, i, a) => callback(v, i));
        }

        public static Dictionary<int, TR> MapValues<TV, TR>(List<TV> list, Func<TV, TR> callback)
        {
            return MapValues(list, (v, i, a) => callback(v));
        }

        public static Dictionary<int, TR> MapValues<TV, TR>(List<TV> list, Func<TR> callback)
        {
            return MapValues(list, (v, i, a) => callback());
        }
    }
}
#pragma warning restore SA1300, SA1649
