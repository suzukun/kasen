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

            foreach ((bool isSuccessed, T value) in array)
            {
                if (isSuccessed)
                {
                    result = value;
                    break;
                }
            }

            return result;
        }
    }
}
#pragma warning restore SA1300, SA1649
