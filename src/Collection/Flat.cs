#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<T> Flat<T>(List<List<T>> lists)
        {
            return Concat(lists.ToArray());
        }
    }
}
#pragma warning restore SA1300, SA1649
