namespace KasenCS
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public static Task Promise(Action<Action, Action<Exception>> action)
        {
            TaskCompletionSource<object> tcs = new();

            action(
                () => tcs.SetResult(null),
                error => tcs.SetException(error));

            return tcs.Task;
        }

        public static Task<T> Promise<T>(Action<Action<T>, Action<Exception>> action)
        {
            TaskCompletionSource<T> tcs = new();

            action(
                result => tcs.SetResult(result),
                error => tcs.SetException(error));

            return tcs.Task;
        }

        public static Task PromiseAll(params Task[] tasks)
        {
            return Task.WhenAll(tasks);
        }

        public static Task<T[]> PromiseAll<T>(params Task<T>[] tasks)
        {
            return Task.WhenAll(tasks);
        }

        public static Task PromiseRace(params Task[] tasks)
        {
            return Task.WhenAny(tasks).Unwrap();
        }

        public static Task<T> PromiseRace<T>(params Task<T>[] tasks)
        {
            return Task.WhenAny(tasks).Unwrap();
        }
    }
}
