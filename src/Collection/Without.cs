#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Dictionary<TK, TV> Without<TK, TV>(IDictionary<TK, TV> dictionary, params TV[] values)
        {
            List<TV> targets = new(values);

            return Filter(dictionary, (v, k) => !Includes(targets, v));
        }

        public static List<T> Without<T>(IList<T> dictionary, params T[] values)
        {
            List<T> targets = new(values);

            return Filter(dictionary, (v, k) => !Includes(targets, v));
        }
    }
}
#pragma warning restore SA1300, SA1649
