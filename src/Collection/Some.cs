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
        public static bool Some<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            bool result = false;

            Each(dictionary, (v, k) =>
            {
                result |= callback(v, k);
            });

            return result;
        }

        public static bool Some<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Some(dictionary, (v, k) => callback(v));
        }

        public static bool Some<T>(IList<T> list, Func<T, int, bool> callback)
        {
            bool result = false;

            Each(list, (v, i) =>
            {
                result |= callback(v, i);
            });

            return result;
        }

        public static bool Some<T>(IList<T> list, Func<T, bool> callback)
        {
            return Some(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
