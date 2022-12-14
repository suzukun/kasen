#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static (List<T1>, List<T2>) Unzip<T1, T2>(List<(T1, T2)> list)
        {
            (List<T1>, List<T2>) result = (new List<T1>(), new List<T2>());

            Each(list, (item) =>
            {
                result.Item1.Add(item.Item1);
                result.Item2.Add(item.Item2);
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
