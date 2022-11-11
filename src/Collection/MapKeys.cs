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
            Dictionary<T, int> result = new Dictionary<T, int>();

            Each(size, (i) =>
            {
                Set(result, callback(i), i);
            });

            return result;
        }

        public static Dictionary<T, int> MapKeys<T>(int size, Func<T> callback)
        {
            return MapKeys(size, (i) => callback());
        }

        public static Dictionary<TR, TV> MapKeys<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, TR> callback)
        {
            Dictionary<TR, TV> result = new Dictionary<TR, TV>();

            Each(dictionary, (v, k, d) =>
            {
                Set(result, callback(v, k, d), v);
            });

            return result;
        }

        public static Dictionary<TR, TV> MapKeys<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TK, TR> callback)
        {
            return MapKeys(dictionary, (v, k, d) => callback(v, k));
        }

        public static Dictionary<TR, TV> MapKeys<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TV, TR> callback)
        {
            return MapKeys(dictionary, (v, k, d) => callback(v));
        }

        public static Dictionary<TR, TV> MapKeys<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR> callback)
        {
            return MapKeys(dictionary, (v, k, d) => callback());
        }

        public static Dictionary<TR, TV> MapKeys<TV, TR>(List<TV> list, Func<TV, int, List<TV>, TR> callback)
        {
            Dictionary<TR, TV> result = new Dictionary<TR, TV>();

            Each(list, (v, i, a) =>
            {
                Set(result, callback(v, i, a), v);
            });

            return result;
        }

        public static Dictionary<TR, TV> MapKeys<TV, TR>(List<TV> list, Func<TV, int, TR> callback)
        {
            return MapKeys(list, (v, i, a) => callback(v, i));
        }

        public static Dictionary<TR, TV> MapKeys<TV, TR>(List<TV> list, Func<TV, TR> callback)
        {
            return MapKeys(list, (v, i, a) => callback(v));
        }

        public static Dictionary<TR, TV> MapKeys<TV, TR>(List<TV> list, Func<TR> callback)
        {
            return MapKeys(list, (v, i, a) => callback());
        }
    }
}
#pragma warning restore SA1300, SA1649
