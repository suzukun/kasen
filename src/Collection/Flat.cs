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
            List<T> result = new();

            Each(lists, (list) =>
            {
                result.AddRange(list);
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
