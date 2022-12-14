#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<T> Slice<T>(List<T> list, int startIndex, int endIndex)
        {
            int si = startIndex >= 0 ? startIndex : list.Count + startIndex;
            int ei = endIndex >= 0 ? endIndex : list.Count + endIndex;
            int index = si;
            int count = ei - si + 1;

            return list.GetRange(index, count);
        }

        public static List<T> Slice<T>(List<T> list, int index)
        {
            return Slice(list, index, list.Count);
        }
    }
}
#pragma warning restore SA1300, SA1649
