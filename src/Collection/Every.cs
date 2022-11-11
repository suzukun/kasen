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
        public static bool Every<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, bool> callback)
        {
            bool result = true;

            Each(dictionary, (v, k, d) =>
            {
                result &= callback(v, k, d);
            });

            return result;
        }

        public static bool Every<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            return Every(dictionary, (v, k, d) => callback(v, k));
        }

        public static bool Every<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Every(dictionary, (v, k, d) => callback(v));
        }

        public static bool Every<T>(List<T> list, Func<T, int, List<T>, bool> callback)
        {
            bool result = true;

            Each(list, (v, i, a) =>
            {
                result &= callback(v, i, a);
            });

            return result;
        }

        public static bool Every<T>(List<T> list, Func<T, int, bool> callback)
        {
            return Every(list, (v, i, a) => callback(v, i));
        }

        public static bool Every<T>(List<T> list, Func<T, bool> callback)
        {
            return Every(list, (v, i, a) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
