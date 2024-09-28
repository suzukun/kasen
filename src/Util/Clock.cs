namespace KasenCS
{
    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public sealed class Clock
        {
            private float startTime = 0f;
            private float beforeTime = 0f;

            public float DeltaTime { get; private set; } = 0f;

            public float ElapsedTime { get; private set; } = 0f;

            public void Clear()
            {
                this.startTime = 0f;
                this.beforeTime = 0f;
                this.DeltaTime = 0f;
                this.ElapsedTime = 0f;
            }

            public void Update(float time)
            {
                if (this.startTime == 0f)
                {
                    this.startTime = time;
                    this.beforeTime = time;
                }

                this.ElapsedTime = time - this.startTime;
                this.DeltaTime = time - this.beforeTime;
                this.beforeTime = time;
            }
        }
    }
}
