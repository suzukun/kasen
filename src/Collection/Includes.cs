#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static bool Includes<TK, TV>(Dictionary<TK, TV> dictionary, TK key, TV value)
        {
            return dictionary.ContainsKey(key) && dictionary[key].Equals(value);
        }

        public static bool Includes<T>(List<T> list, T value)
        {
            return list.Contains(value);
        }
    }
}
#pragma warning restore SA1300, SA1649
