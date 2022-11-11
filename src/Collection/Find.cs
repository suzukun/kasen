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
        public static KeyValuePair<TK, TV> Find<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, Dictionary<TK, TV>, bool> callback)
        {
            KeyValuePair<TK, TV> result = default;
            bool isFinded = false;

            Each(dictionary, (v, k, d) =>
            {
                if (isFinded)
                {
                    return;
                }

                bool isTarget = callback(v, k, d);

                if (isTarget)
                {
                    isFinded = true;
                    result = new KeyValuePair<TK, TV>(k, v);
                }
            });

            return result;
        }

        public static KeyValuePair<TK, TV> Find<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, TK, bool> callback)
        {
            return Find(dictionary, (v, k, d) => callback(v, k));
        }

        public static KeyValuePair<TK, TV> Find<TK, TV>(Dictionary<TK, TV> dictionary, Func<TV, bool> callback)
        {
            return Find(dictionary, (v, k, d) => callback(v));
        }

        public static T Find<T>(List<T> list, Func<T, int, List<T>, bool> callback)
        {
            T result = default;
            bool isFinded = false;

            Each(list, (v, i, a) =>
            {
                if (isFinded)
                {
                    return;
                }

                bool isTarget = callback(v, i, a);

                if (isTarget)
                {
                    isFinded = true;
                    result = v;
                }
            });

            return result;
        }

        public static T Find<T>(List<T> list, Func<T, int, bool> callback)
        {
            return Find(list, (v, i, a) => callback(v, i));
        }

        public static T Find<T>(List<T> list, Func<T, bool> callback)
        {
            return Find(list, (v, i, a) => callback(v));
        }
    }
}
#pragma warning restore SA1300, SA1649
