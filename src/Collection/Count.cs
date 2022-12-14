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
        public static int Count<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, bool> callback)
        {
            int result = 0;

            Each(dictionary, (v, k, d) =>
            {
                bool isTarget = callback(v, k, d);

                if (isTarget)
                {
                    result++;
                }
            });

            return result;
        }

        public static int Count<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            return Count(dictionary, (v, k, d) => callback(v, k));
        }

        public static int Count<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Count(dictionary, (v, k, d) => callback(v));
        }

        public static int Count<T>(List<T> list, Func<T, int, List<T>, bool> callback)
        {
            int result = 0;

            Each(list, (v, i, a) =>
            {
                bool isTarget = callback(v, i, a);

                if (isTarget)
                {
                    result++;
                }
            });

            return result;
        }

        public static int Count<T>(List<T> list, Func<T, int, bool> callback)
        {
            return Count(list, (v, i, a) => callback(v, i));
        }

        public static int Count<T>(List<T> list, Func<T, bool> callback)
        {
            return Count(list, (v, i, a) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
