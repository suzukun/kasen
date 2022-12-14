#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static string SnakeCase(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            string joined = Regex.Replace(value, @"[A-Z]+", (match) =>
            {
                string result = "_" + match.Value;

                return match.Result(result);
            });
            string middle = Regex.Replace(joined, @"(^(-|_|\s)+|(-|_|\s)+$)", string.Empty);
            string replaced = Regex.Replace(middle, @"(-|_|\s)+", "_").ToLower();

            return replaced;
        }
    }
}
#pragma warning restore SA1300, SA1649
