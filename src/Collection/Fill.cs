#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Dictionary<TK, TV> Fill<TK, TV>(IDictionary<TK, TV> dictionary, TV value)
        {
            return MapValues(dictionary, (_) => value);
        }

        public static List<T> Fill<T>(IList<T> list, T value)
        {
            return Map(list, (_) => value);
        }
    }
}
#pragma warning restore SA1300, SA1649
