namespace KasenCS
{
    using System.Threading.Tasks;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public static Task Wait(float seconds)
        {
            return Task.Delay((int)(seconds * 1000));
        }

        public static Task WaitOneFrame()
        {
            return Task.Delay(1);
        }
    }
}
