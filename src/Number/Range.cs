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
        public static List<int> Range(int size)
        {
            return size == 0 ? new List<int>() : Range(0, Math.Max(size - 1, 0));
        }

        public static List<int> Range(int start, int end)
        {
            int direction = end >= 0 ? 1 : -1;
            int max = Math.Max(start, end);
            int min = Math.Min(start, end);
            int size = Math.Abs(max - min) + 1;

            return Map(size, (i) => start + (i * direction));
        }
    }
}
#pragma warning restore SA1300, SA1649
