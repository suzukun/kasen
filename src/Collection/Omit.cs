#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Dictionary<TK, TV> Omit<TK, TV>(Dictionary<TK, TV> dictionary, params TK[] keys)
        {
            List<TK> targets = new List<TK>(keys);

            return Filter(dictionary, (v, k) => !Includes(targets, k));
        }

        public static List<T> Omit<T>(List<T> dictionary, params int[] keys)
        {
            List<int> targets = new List<int>(keys);

            return Filter(dictionary, (v, k) => !Includes(targets, k));
        }
    }
}
#pragma warning restore SA1300, SA1649
