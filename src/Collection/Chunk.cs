#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<List<T>> Chunk<T>(IList<T> list, int size = 1)
        {
            List<List<T>> result = new();
            int s = Math.Max(1, size);

            Each(list, (v, i) =>
            {
                int index = i / s;

                if (result.Count <= index)
                {
                    result.Add(new());
                }

                result[index].Add(v);
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
