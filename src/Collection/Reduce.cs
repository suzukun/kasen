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

        public static T Reduce<T>(int size, Func<T> callback, T initial = default)
        {
            return Reduce(size, (r, i) => callback(), initial);
        }

        public static TR Reduce<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR, TV, TK, Dictionary<TK, TV>, TR> callback, TR initial = default)
        {
            TR result = initial;

            Each(dictionary, (v, k, d) =>
            {
                result = callback(result, v, k, d);
            });

            return result;
        }

        public static TR Reduce<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR, TV, TK, TR> callback, TR initial = default)
        {
            return Reduce(dictionary, (r, v, k, d) => callback(r, v, k), initial);
        }

        public static TR Reduce<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR, TV, TR> callback, TR initial = default)
        {
            return Reduce(dictionary, (r, v, k, d) => callback(r, v), initial);
        }

        public static TR Reduce<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR, TR> callback, TR initial = default)
        {
            return Reduce(dictionary, (r, v, k, d) => callback(r), initial);
        }

        public static TR Reduce<TK, TV, TR>(Dictionary<TK, TV> dictionary, Func<TR> callback, TR initial = default)
        {
            return Reduce(dictionary, (r, v, k, d) => callback(), initial);
        }

        public static TR Reduce<TV, TR>(List<TV> list, Func<TR, TV, int, List<TV>, TR> callback, TR initial = default)
        {
            TR result = initial;

            Each(list, (v, i, a) =>
            {
                result = callback(result, v, i, a);
            });

            return result;
        }

        public static TR Reduce<TV, TR>(List<TV> list, Func<TR, TV, int, TR> callback, TR initial = default)
        {
            return Reduce(list, (r, v, i, a) => callback(r, v, i), initial);
        }

        public static TR Reduce<TV, TR>(List<TV> list, Func<TR, TV, TR> callback, TR initial = default)
        {
            return Reduce(list, (r, v, i, a) => callback(r, v), initial);
        }

        public static TR Reduce<TV, TR>(List<TV> list, Func<TR, TR> callback, TR initial = default)
        {
            return Reduce(list, (r, v, i, a) => callback(r), initial);
        }

        public static TR Reduce<TV, TR>(List<TV> list, Func<TR> callback, TR initial = default)
        {
            return Reduce(list, (v, i, a) => callback(), initial);
        }
    }
}
#pragma warning restore SA1300, SA1649
