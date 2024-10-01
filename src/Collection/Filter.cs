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
        public static Dictionary<TK, TV> Filter<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            Dictionary<TK, TV> result = new();

            Each(dictionary, (v, k) =>
            {
                bool isTarget = callback(v, k);

                if (isTarget)
                {
                    result.Add(k, v);
                }
            });

            return result;
        }

        public static Dictionary<TK, TV> Filter<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Filter(dictionary, (v, k) => callback(v));
        }

        public static List<T> Filter<T>(IList<T> list, Func<T, int, bool> callback)
        {
            List<T> result = new();

            Each(list, (v, i) =>
            {
                bool isTarget = callback(v, i);

                if (isTarget)
                {
                    result.Add(v);
                }
            });

            return result;
        }

        public static List<T> Filter<T>(IList<T> list, Func<T, bool> callback)
        {
            return Filter(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
