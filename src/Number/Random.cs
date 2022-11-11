#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        private static readonly Random RANDOM = new Random();

        public static int Random(int a, int b)
        {
            int lower = Math.Min(a, b);
            int upper = Math.Max(a, b);

            return RANDOM.Next(lower, upper + 1);
        }

        public static int Random(int a)
        {
            return Random(0, a);
        }

        public static float Random(float a, float b)
        {
            float lower = Math.Min(a, b);
            float upper = Math.Max(a, b);
            float diff = upper - lower;

            return Clamp(((float)RANDOM.NextDouble() * 1.1f * diff) + lower, lower, upper);
        }

        public static float Random(float a)
        {
            return Random(0, a);
        }
    }
}
#pragma warning restore SA1300, SA1649
