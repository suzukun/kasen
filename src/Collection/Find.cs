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
        public static KeyValuePair<TK, TV> Find<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            KeyValuePair<TK, TV> result = default;
            bool isFinded = false;

            Each(dictionary, (v, k) =>
            {
                if (isFinded)
                {
                    return;
                }

                bool isTarget = callback(v, k);

                if (isTarget)
                {
                    isFinded = true;
                    result = new KeyValuePair<TK, TV>(k, v);
                }
            });

            return result;
        }

        public static KeyValuePair<TK, TV> Find<TK, TV>(IDictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Find(dictionary, (v, k) => callback(v));
        }

        public static T Find<T>(IList<T> list, Func<T, int, bool> callback)
        {
            T result = default;
            bool isFinded = false;

            Each(list, (v, i) =>
            {
                if (isFinded)
                {
                    return;
                }

                bool isTarget = callback(v, i);

                if (isTarget)
                {
                    isFinded = true;
                    result = v;
                }
            });

            return result;
        }

        public static T Find<T>(IList<T> list, Func<T, bool> callback)
        {
            return Find(list, (v, i) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
