#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static string WordBreak(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            string processed = value;

            processed = Regex.Replace(processed, @"([A-Z]|-|_|\s|,)+", (match) =>
            {
                string result = Regex.Replace("," + match.Value, @"(-|_|\s|,)+", ",");

                return match.Result(result);
            });
            processed = Regex.Replace(processed, @"(^,+|,+$)", string.Empty);

            return processed;
        }
    }
}
#pragma warning restore SA1300, SA1649
