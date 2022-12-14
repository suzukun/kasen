#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static string CamelCase(string value, bool isUpper = false)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            string middle = Regex.Replace(value, @"(^(-|_|\s)+|(-|_|\s)+$)", string.Empty);
            string replaced = Regex.Replace(middle, @"(-|_|\s)+.", (match) =>
            {
                string result = match.Value.Substring(match.Length - 1).ToUpper();

                return match.Result(result);
            });
            string first = replaced.Substring(0, 1);

            return (isUpper ? first.ToUpper() : first.ToLower()) + replaced.Substring(1);
        }
    }
}
#pragma warning restore SA1300, SA1649
