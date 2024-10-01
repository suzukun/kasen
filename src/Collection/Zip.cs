#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<(T1, T2)> Zip<T1, T2>(IList<T1> a, IList<T2> b)
        {
            List<(T1, T2)> result = new();

            Each(a, (v, i) =>
            {
                result.Add((v, b[i]));
            });

            return result;
        }

        public static List<(T1, T2)> Zip<T1, T2>((IList<T1>, IList<T2>) tuples)
        {
            List<(T1, T2)> result = new();

            Each(tuples.Item1, (v, i) =>
            {
                result.Add((v, tuples.Item2[i]));
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
