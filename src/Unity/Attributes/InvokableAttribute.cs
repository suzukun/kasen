namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public enum InvokableMode
        {
            All,
            PlayOnly,
            EditOnly,
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
        public class InvokableAttribute : Attribute
        {
            public InvokableAttribute(InvokableMode mode = InvokableMode.All, params object[] parameters)
            {
                this.Mode = mode;
                this.Parameters = parameters;
            }

            public InvokableMode Mode { get; }

            public object[] Parameters { get; set; }
        }
    }
}
