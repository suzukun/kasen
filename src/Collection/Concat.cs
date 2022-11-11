#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Dictionary<TK, TV> Concat<TK, TV>(params Dictionary<TK, TV>[] dictionaries)
        {
            Dictionary<TK, TV> result = new Dictionary<TK, TV>();

            foreach (Dictionary<TK, TV> dictionary in dictionaries)
            {
                Each(dictionary, (v, k) =>
                {
                    Set(result, k, v);
                });
            }

            return result;
        }

        public static List<T> Concat<T>(params List<T>[] lists)
        {
            List<T> result = new List<T>();

            foreach (List<T> list in lists)
            {
                result.AddRange(list);
            }

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
