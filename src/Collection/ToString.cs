#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static string ToString<TK, TV>(IDictionary<TK, TV> dictionary, string separator = "\n")
        {
            string result = string.Empty;

            Each(dictionary, (v, k) =>
            {
                result += "{" + $"{k}:{v}" + "}" + separator;
            });

            return result;
        }

        public static string ToString<T>(List<T> list, string separator = ",")
        {
            return string.Join(separator, list.ToArray());
        }
    }
}
#pragma warning restore SA1300, SA1649
