namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public sealed class Observe<T>
        {
            private T value;

            public Observe(T defaultValue = default)
            {
                this.value = defaultValue;
            }

            public event Action<T> OnChange;

            public T Value
            {
                get => this.value;
                set
                {
                    if (!this.value.Equals(value))
                    {
                        this.OnChange.Invoke(value);
                    }

                    this.value = value;
                }
            }
        }
    }
}
