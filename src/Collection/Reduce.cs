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
        public static T Reduce<T>(int size, Func<T, int, T> callback, T initial = default)
        {
            T result = initial;

            Each(size, (i) =>
            {
                result = callback(result, i);
            });

            return result;
        }

        public static T Reduce<T>(int size, Func<T, T> callback, T initial = default)
        {
            return Reduce(size, (r, i) => callback(r), initial);
        }

        public static TR Reduce<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TR, TV, TK, TR> callback, TR initial = default)
        {
            TR result = initial;

            Each(dictionary, (v, k) =>
            {
                result = callback(result, v, k);
            });

            return result;
        }

        public static TR Reduce<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TR, TV, TR> callback, TR initial = default)
        {
            return Reduce(dictionary, (r, v, k) => callback(r, v), initial);
        }

        public static TR Reduce<TK, TV, TR>(IDictionary<TK, TV> dictionary, Func<TR, TR> callback, TR initial = default)
        {
            return Reduce(dictionary, (r, v, k) => callback(r), initial);
        }

        public static TR Reduce<TV, TR>(IList<TV> list, Func<TR, TV, int, TR> callback, TR initial = default)
        {
            TR result = initial;

            Each(list, (v, i) =>
            {
                result = callback(result, v, i);
            });

            return result;
        }

        public static TR Reduce<TV, TR>(IList<TV> list, Func<TR, TV, TR> callback, TR initial = default)
        {
            return Reduce(list, (r, v, i) => callback(r, v), initial);
        }

        public static TR Reduce<TV, TR>(IList<TV> list, Func<TR, TR> callback, TR initial = default)
        {
            return Reduce(list, (r, v, i) => callback(r), initial);
        }
    }
}
#pragma warning restore SA1300, SA1649
