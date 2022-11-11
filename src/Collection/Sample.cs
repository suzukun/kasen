#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static KeyValuePair<TK, TV> Sample<TK, TV>(Dictionary<TK, TV> dictionary)
        {
            if (dictionary.Count == 0)
            {
                return default;
            }

            TK[] keys = new TK[dictionary.Count];

            dictionary.Keys.CopyTo(keys, 0);

            TK key = keys[Random(0, keys.Length - 1)];

            return new KeyValuePair<TK, TV>(key, dictionary[key]);
        }

        public static T Sample<T>(List<T> list)
        {
            return list.Count == 0 ? default : list[Random(0, list.Count - 1)];
        }
    }
}
#pragma warning restore SA1300, SA1649
