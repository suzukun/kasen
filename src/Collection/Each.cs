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

        public static void Each<T>(IList<T> list, Action<T, int> callback)
        {
            int i = 0;

            foreach (T item in list)
            {
                callback(item, i);
                i++;
            }
        }

        public static void Each<T>(IList<T> list, Action<T> callback)
        {
            foreach (T item in list)
            {
                callback(item);
            }
        }

        public static void Each<TK, TV>(IDictionary<TK, TV> dictionary, Action<TV, TK> callback)
        {
            foreach (KeyValuePair<TK, TV> item in dictionary)
            {
                callback(item.Value, item.Key);
            }
        }

        public static void Each<TK, TV>(IDictionary<TK, TV> dictionary, Action<TV> callback)
        {
            foreach (KeyValuePair<TK, TV> item in dictionary)
            {
                callback(item.Value);
            }
        }

        public static void Each(IEnumerable<object> objectList, Action callback)
        {
            foreach (object _ in objectList)
            {
                callback();
            }
        }
    }
}
#pragma warning restore SA1300, SA1649
