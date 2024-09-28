#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        private static int uniqueId = 0;

        public static int UniqueId()
        {
            return uniqueId++;
        }
    }
}
#pragma warning restore SA1300, SA1649
