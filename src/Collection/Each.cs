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
        public static void Each(int size, Action<int> callback)
        {
            for (int i = 0; i < size; i++)
            {
                callback(i);
            }
        }

        public static void Each(int size, Action callback)
        {
            Each(size, (i) =>
            {
                callback();
            });
        }

        public static void Each<TK, TV>(Dictionary<TK, TV> dictionary, Action<TV, TK, Dictionary<TK, TV>> callback)
        {
            foreach (KeyValuePair<TK, TV> item in dictionary)
            {
                callback(item.Value, item.Key, dictionary);
            }
        }

        public static void Each<TK, TV>(Dictionary<TK, TV> dictionary, Action<TV, TK> callback)
        {
            Each(dictionary, (v, k, d) =>
            {
                callback(v, k);
            });
        }

        public static void Each<TK, TV>(Dictionary<TK, TV> dictionary, Action<TV> callback)
        {
            Each(dictionary, (v, k, d) =>
            {
                callback(v);
            });
        }

        public static void Each<TK, TV>(Dictionary<TK, TV> dictionary, Action callback)
        {
            Each(dictionary.Count, callback);
        }

        public static void Each<T>(List<T> list, Action<T, int, List<T>> callback)
        {
            int index = 0;

            list.ForEach(value =>
            {
                callback(value, index, list);

                index++;
            });
        }

        public static void Each<T>(List<T> list, Action<T, int> callback)
        {
            Each(list, (v, i, a) =>
            {
                callback(v, i);
            });
        }

        public static void Each<T>(List<T> list, Action<T> callback)
        {
            Each(list, (v, i, a) =>
            {
                callback(v);
            });
        }

        public static void Each<T>(List<T> list, Action callback)
        {
            Each(list.Count, callback);
        }
    }
}
#pragma warning restore SA1300, SA1649
