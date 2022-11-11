#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static T Last<T>(List<T> list)
        {
            return list[^1];
        }
    }
}
#pragma warning restore SA1300, SA1649
