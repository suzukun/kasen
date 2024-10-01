#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Dictionary<TK, TV> Concat<TK, TV>(params IDictionary<TK, TV>[] dictionaries)
        {
            Dictionary<TK, TV> result = new();

            Each(dictionaries, (dictionary) =>
            {
                Each(dictionary, (v, k) =>
                {
                    Set(result, k, v);
                });
            });

            return result;
        }

        public static List<T> Concat<T>(params IList<T>[] lists)
        {
            List<T> result = new();

            Each(lists, (list) =>
            {
                result.AddRange(list);
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
