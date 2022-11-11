#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static int Clamp(int x, int lower, int upper)
        {
            return Math.Min(Math.Max(x, lower), upper);
        }

        public static float Clamp(float x, float lower, float upper)
        {
            return Math.Min(Math.Max(x, lower), upper);
        }
    }
}
#pragma warning restore SA1300, SA1649
