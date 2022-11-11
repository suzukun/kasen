#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static bool InRange(int x, int lower, int upper)
        {
            return x >= lower && x <= upper;
        }

        public static bool InRange(float x, float lower, float upper)
        {
            return x >= lower && x <= upper;
        }
    }
}
#pragma warning restore SA1300, SA1649
