#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<T> Xor<T>(List<T> a, List<T> b)
        {
            List<T> result = Concat(Difference(a, b), Difference(b, a));

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
