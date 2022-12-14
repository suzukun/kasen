#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<T> Intersection<T>(List<T> a, List<T> b)
        {
            List<T> result = Filter(a, (v) => Includes(b, v));

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
