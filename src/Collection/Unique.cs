#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<T> Unique<T>(List<T> list)
        {
            List<T> result = new List<T>();

            Each(list, v =>
            {
                if (!Includes(result, v))
                {
                    result.Add(v);
                }
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
