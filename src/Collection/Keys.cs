#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<TK> Keys<TK, TV>(IDictionary<TK, TV> dictionary)
        {
            TK[] keys = new TK[dictionary.Count];

            dictionary.Keys.CopyTo(keys, 0);

            return new List<TK>(keys);
        }

        public static List<int> Keys<T>(IList<T> list)
        {
            return Range(list.Count);
        }
    }
}
#pragma warning restore SA1300, SA1649
