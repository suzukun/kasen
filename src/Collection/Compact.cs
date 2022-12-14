#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static List<int> Compact(List<int> list)
        {
            List<int> result = Filter(list, v => v != 0);

            return result;
        }

        public static List<float> Compact(List<float> list)
        {
            List<float> result = Filter(list, v => v != 0f);

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
