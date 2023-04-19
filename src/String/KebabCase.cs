#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static string KebabCase(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            string values = WordBreak(value);
            string replaced = Regex.Replace(values, @",", "-").ToLower();

            return replaced;
        }
    }
}
#pragma warning restore SA1300, SA1649
