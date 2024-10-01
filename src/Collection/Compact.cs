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
        public static List<T> Compact<T>(IList<T> list)
        {
            List<T> result = Filter(list, v => Convert.ToBoolean(v));

            return result;
        }

        public static List<string> Compact(List<string> list)
        {
            List<string> result = Filter(list, v => !string.IsNullOrEmpty(v));

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
