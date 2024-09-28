namespace KasenCS
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public class EventEmitter<T>
            where T : Enum
        {
            private Dictionary<T, List<Action<object>>> listeners = new();

            public void Emit(T name, object data = null)
            {
                if (!this.listeners.ContainsKey(name))
                {
                    return;
                }

                foreach (Action<object> listener in this.listeners[name])
                {
                    listener(data);
                }
            }

            public void Off()
            {
                this.listeners.Clear();
            }

            public void Off(T name)
            {
                if (!this.listeners.ContainsKey(name))
                {
                    return;
                }

                this.listeners.Remove(name);
            }

            public void Off(T name, Action<object> listener)
            {
                if (!this.listeners.ContainsKey(name))
                {
                    return;
                }

                this.listeners[name].Remove(listener);
            }

            public void On(T name, Action<object> listener)
            {
                if (!this.listeners.ContainsKey(name))
                {
                    this.listeners[name] = new();
                }

                this.listeners[name].Add(listener);
            }
        }
    }
}
