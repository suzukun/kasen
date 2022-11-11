#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Action Once(Action action)
        {
            bool isOned = false;

            return () =>
            {
                if (isOned)
                {
                    return;
                }

                isOned = true;

                action();
            };
        }
    }
}
#pragma warning restore SA1300, SA1649
