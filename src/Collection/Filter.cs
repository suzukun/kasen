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
        public static Dictionary<TK, TV> Filter<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, bool> callback)
        {
            Dictionary<TK, TV> result = new Dictionary<TK, TV>();

            Each(dictionary, (v, k, d) =>
            {
                bool isTarget = callback(v, k, d);

                if (isTarget)
                {
                    result.Add(k, v);
                }
            });

            return result;
        }

        public static Dictionary<TK, TV> Filter<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            return Filter(dictionary, (v, k, d) => callback(v, k));
        }

        public static Dictionary<TK, TV> Filter<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Filter(dictionary, (v, k, d) => callback(v));
        }

        public static List<T> Filter<T>(List<T> list, Func<T, int, List<T>, bool> callback)
        {
            List<T> result = new List<T>();

            Each(list, (v, i, a) =>
            {
                bool isTarget = callback(v, i, a);

                if (isTarget)
                {
                    result.Add(v);
                }
            });

            return result;
        }

        public static List<T> Filter<T>(List<T> list, Func<T, int, bool> callback)
        {
            return Filter(list, (v, i, a) => callback(v, i));
        }

        public static List<T> Filter<T>(List<T> list, Func<T, bool> callback)
        {
            return Filter(list, (v, i, a) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
