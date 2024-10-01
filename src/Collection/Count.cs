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
        public static int Count<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            int result = 0;

            Each(dictionary, (v, k) =>
            {
                bool isTarget = callback(v, k);

                if (isTarget)
                {
                    result++;
                }
            });

            return result;
        }

        public static int Count<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Count(dictionary, (v, k) => callback(v));
        }

        public static int Count<T>(IList<T> list, Func<T, int, bool> callback)
        {
            int result = 0;

            Each(list, (v, i) =>
            {
                bool isTarget = callback(v, i);

                if (isTarget)
                {
                    result++;
                }
            });

            return result;
        }

        public static int Count<T>(IList<T> list, Func<T, bool> callback)
        {
            return Count(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
