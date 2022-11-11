#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;
    using System.Timers;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Action Throttle(Action action, int interval = 1000)
        {
            bool isProgressed = true;
            Timer timer = new Timer(interval)
            {
                AutoReset = false,
            };

            timer.Elapsed += (s, e) =>
            {
                isProgressed = true;

                timer.Stop();
            };

            return () =>
            {
                if (!isProgressed)
                {
                    return;
                }

                isProgressed = false;

                timer.Start();

                action();
            };
        }
    }
}
#pragma warning restore SA1300, SA1649
