#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Dictionary<TK, TV> Fill<TK, TV>(Dictionary<TK, TV> dictionary, TV value)
        {
            return MapValues(dictionary, () => value);
        }

        public static List<T> Fill<T>(List<T> list, T value)
        {
            return Map(list, () => value);
        }
    }
}
#pragma warning restore SA1300, SA1649
