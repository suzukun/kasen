#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static int RangeMapper(int x, int fromMin, int fromMax, int toMin, int toMax)
        {
            return (int)MathF.Floor(toMin + ((x - fromMin) * (toMax - toMin) / (fromMax - fromMin)));
        }

        public static float RangeMapper(float x, float fromMin, float fromMax, float toMin, float toMax)
        {
            return toMin + ((x - fromMin) * (toMax - toMin) / (fromMax - fromMin));
        }
    }
}
#pragma warning restore SA1300, SA1649
