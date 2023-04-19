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

            string values = WordBreak(value);
            string replaced = Regex.Replace(values, @",", "_").ToLower();

            return replaced;
        }
    }
}
#pragma warning restore SA1300, SA1649
