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
        public static bool Every<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            bool result = true;

            Each(dictionary, (v, k) =>
            {
                result &= callback(v, k);
            });

            return result;
        }

        public static bool Every<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Every(dictionary, (v, k) => callback(v));
        }

        public static bool Every<T>(IList<T> list, Func<T, int, bool> callback)
        {
            bool result = true;

            Each(list, (v, i) =>
            {
                result &= callback(v, i);
            });

            return result;
        }

        public static bool Every<T>(IList<T> list, Func<T, bool> callback)
        {
            return Every(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
