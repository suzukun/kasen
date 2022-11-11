#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<TV> Values<TK, TV>(Dictionary<TK, TV> dictionary)
        {
            TV[] values = new TV[dictionary.Count];

            dictionary.Values.CopyTo(values, 0);

            return new List<TV>(values);
        }
    }
}
#pragma warning restore SA1300, SA1649
