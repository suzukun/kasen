#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static T Verify<T>(params (bool, T)[] array)
        {
            T result = default;

            Each(array, (e) =>
            {
                if (e.Item1)
                {
                    result = e.Item2;
                }
            });

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
