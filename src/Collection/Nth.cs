#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static T Nth<T>(IList<T> list, int index)
        {
            int i = Clamp(index >= 0 ? index : list.Count + index, 0, list.Count - 1);

            return list[i];
        }
    }
}
#pragma warning restore SA1300, SA1649
