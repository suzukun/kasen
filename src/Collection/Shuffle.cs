#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<T> Shuffle<T>(List<T> list)
        {
            List<T> result = new List<T>(list);

            Each(result.Count, () =>
            {
                int from = Random(result.Count - 1);
                int to = Random(result.Count - 1);

                (result[from], result[to]) = (result[to], result[from]);
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
